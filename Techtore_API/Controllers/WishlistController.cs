using Microsoft.AspNetCore.Mvc;

namespace Techtore_API.Controllers
{
    public class WishlistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
