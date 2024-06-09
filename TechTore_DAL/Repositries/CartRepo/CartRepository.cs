using TechTore_DAL.Models;
using TechTore_DAL.Repositries._GenericRepository;

namespace _TechTore_DAL.Repositries.CartRepo
{
    public class CartRepository : GenericRepository<Cart>, ICartRepository
    {
        public CartRepository(Test1Context test1Context) : base(test1Context)
        {
        }
    }
}
