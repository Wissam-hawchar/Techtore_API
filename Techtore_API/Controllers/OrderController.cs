using Microsoft.AspNetCore.Mvc;

namespace Techtore_API.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
