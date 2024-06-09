using _TechTore_BLL.DTO;
using _TechTore_BLL.Services.CartWithItemsServices;
using _TechTore_BLL.Wrapping.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Techtore_API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CartController : GenericController<CartWithItemsDTO>
    {
        private readonly ICartWithItemsService _cartWithItemsService;
        public CartController(ICartWithItemsService genericService) : base(genericService)
        {
            _cartWithItemsService = genericService;
        }
        [HttpPost("AddCartWithItems")]
        public APIResponse<CartWithItemsDTO> AddCartWithItems(CartWithItemsDTO cartWithItemsDto)
        {
            return _cartWithItemsService.AddCartWithItems(cartWithItemsDto);
        }
    }
}
