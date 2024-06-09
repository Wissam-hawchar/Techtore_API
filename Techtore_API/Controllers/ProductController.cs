using _TechTore_BLL.DTO;
using _TechTore_BLL.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace Techtore_API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ProductController : GenericController<ProductDTO>
    {
        private readonly IProductService _productService;
        public ProductController(IProductService genericService) : base(genericService)
        {
            _productService = genericService;
        }
    }
}
