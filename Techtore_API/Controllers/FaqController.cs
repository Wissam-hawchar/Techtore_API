using Microsoft.AspNetCore.Mvc;

namespace Techtore_API.Controllers
{
    public class FaqController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
