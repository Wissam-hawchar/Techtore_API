using _TechTore_DAL.Repositries.ProductRepo;

using TechTore_DAL.Models;
using TechTore_DAL.Repositries._GenericRepository;

namespace _TechTore_DAL.Repositries.ProductRepo
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(Test1Context test1Context) : base(test1Context)
        {
        }
    }
}
