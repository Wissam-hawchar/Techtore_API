using _TechTore_BLL.DTO;
using _TechTore_BLL.Services.AccountingServices;
using Microsoft.AspNetCore.Mvc;

namespace Techtore_API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AccountingController : GenericController<AccountingDTO>
    {
        private readonly IAccountingService _accountingService;
        public AccountingController(IAccountingService genericService) : base(genericService)
        {
            _accountingService = genericService;
        }
    }
}
