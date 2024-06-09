using Microsoft.AspNetCore.Mvc;

namespace Techtore_API.Controllers
{
    public class UserMessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
