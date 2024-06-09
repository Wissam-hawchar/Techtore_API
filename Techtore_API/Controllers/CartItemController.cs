using Microsoft.AspNetCore.Mvc;

namespace Techtore_API.Controllers
{
    public class CartItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
