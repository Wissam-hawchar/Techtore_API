using _TechTore_BLL.DTO;
using _TechTore_BLL.Services.UserServices;
using Microsoft.AspNetCore.Mvc;

namespace Techtore_API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : GenericController<UserDTO>
    {
        private readonly IUserService _UserService;
        public UserController(IUserService genericService) : base(genericService)
        {
            _UserService = genericService;
        }
    }
}
