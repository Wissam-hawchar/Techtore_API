using Microsoft.AspNetCore.Mvc;

namespace Techtore_API.Controllers
{
    public class FeaturedProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
