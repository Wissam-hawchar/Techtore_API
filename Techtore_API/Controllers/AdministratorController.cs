using Microsoft.AspNetCore.Mvc;

namespace Techtore_API.Controllers
{
    public class AdministratorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
