using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTore_DAL.Models;
using TechTore_DAL.Repositries._GenericRepository;

namespace _TechTore_DAL.Repositries.AccountingRepo
{
    public interface IAccountingRepository : IGenericRepository<Accounting>
    {
    }
}
