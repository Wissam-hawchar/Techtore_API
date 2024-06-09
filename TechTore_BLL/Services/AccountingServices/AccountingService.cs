using _TechTore_BLL.DTO;
using _TechTore_BLL.Services._GenericServices;
using _TechTore_DAL.Repositries.AccountingRepo;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTore_DAL.Models;

namespace _TechTore_BLL.Services.AccountingServices
{
    using Entity = TechTore_DAL.Models.Accounting;
    using Dto = _TechTore_BLL.DTO.AccountingDTO;
    public class AccountingService : GenericService<Entity, Dto>, IAccountingService
    {
        private readonly IAccountingRepository _accountingRepository;
        private readonly IMapper _mapper;
        public AccountingService(IAccountingRepository accountingRepository, IMapper mapper) : base(accountingRepository, mapper)
        {
            _accountingRepository = accountingRepository;
            _mapper = mapper;
        }

    }
}
