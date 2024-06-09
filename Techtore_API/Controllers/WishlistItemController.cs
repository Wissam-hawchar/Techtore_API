using Microsoft.AspNetCore.Mvc;

namespace Techtore_API.Controllers
{
    public class WishlistItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
