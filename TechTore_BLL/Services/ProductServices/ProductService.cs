using _TechTore_BLL.Services._GenericServices;
using _TechTore_DAL.Repositries.ProductRepo;
using AutoMapper;


namespace _TechTore_BLL.Services.ProductServices
{
    using Entity = TechTore_DAL.Models.Product;
    using Dto = _TechTore_BLL.DTO.ProductDTO;
    public class ProductService : GenericService<Entity, Dto>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepository, IMapper mapper) : base(productRepository, mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
    }
}
