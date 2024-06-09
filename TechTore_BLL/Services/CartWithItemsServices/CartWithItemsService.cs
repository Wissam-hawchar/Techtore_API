using _TechTore_BLL.DTO;
using _TechTore_BLL.Services._GenericServices;
using _TechTore_BLL.Wrapping.Exceptions;
using _TechTore_DAL.Repositries.CartItemRepo;
using _TechTore_DAL.Repositries.CartRepo;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Transactions;
using TechTore_DAL.Models;

namespace _TechTore_BLL.Services.CartWithItemsServices
{
    using Entity = TechTore_DAL.Models.Cart;
    using Dto = _TechTore_BLL.DTO.CartWithItemsDTO;
    public delegate void PreCreateDelegate(CartWithItemsDTO cwidto);
    public delegate void PostCreateDelegate(CartWithItemsDTO cwidto);
    public class CartWithItemsService : GenericService<Entity, Dto>, ICartWithItemsService
    {
        private readonly ICartRepository _cartRepository;
        private readonly ICartItemRepository _cartItemRepository;
        private readonly IMapper _mapper;
        public event PreCreateDelegate OnPreCreate;
        public event PostCreateDelegate OnPostCreate;
        public CartWithItemsService(ICartRepository cartRepository, IMapper mapper) : base(cartRepository, mapper)
        {
            _cartRepository = cartRepository;
            _mapper = mapper;
        }


        public  APIResponse<Dto> AddCartWithItems(Dto dto)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    OnPreCreate?.Invoke(dto);
                    var response = new APIResponse<Dto>();
                    var entity = _mapper.Map<Entity>(dto);
                    if (entity == null)
                    {
                        throw new Exception("Null");
                    }
                    var result = _cartRepository.Add(entity);
                    response.Data = _mapper.Map<Dto>(result);

                    foreach (var item in dto.CartItems)
                    {
                        item.CartId = result.CartId;
                        var entityItem = _mapper.Map<CartItem>(dto.CartItems);
                        if (entityItem == null)
                        {
                            throw new Exception("Null");
                        }
                        var resultItem = _cartItemRepository.Add(entityItem);
                        var cartItemDto = _mapper.Map<CartItemDTO>(resultItem);
                        response.Data.CartItems.Add(cartItemDto);
                    }

                    scope.Complete();

                    OnPostCreate?.Invoke(dto);

                    return response;
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    var response = new APIResponse<Dto>()
                    {
                        Success = false,
                        ErrorMessage = ex.Message
                    };
                    return response;
                }
            }
            
        }
    }
}
