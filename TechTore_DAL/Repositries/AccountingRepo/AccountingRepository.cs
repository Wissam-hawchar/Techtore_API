using TechTore_DAL.Models;
using TechTore_DAL.Repositries._GenericRepository;

namespace _TechTore_DAL.Repositries.AccountingRepo
{
    public class AccountingRepository : GenericRepository<Accounting>, IAccountingRepository
    {
        public AccountingRepository(Test1Context test1Context) : base(test1Context)
        {
        }
    }
}
