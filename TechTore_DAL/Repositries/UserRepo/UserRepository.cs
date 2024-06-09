using TechTore_DAL.Models;
using TechTore_DAL.Repositries._GenericRepository;

namespace _TechTore_DAL.Repositries.UserRepo
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(Test1Context test1Context) : base(test1Context)
        {
        }
    }
}
