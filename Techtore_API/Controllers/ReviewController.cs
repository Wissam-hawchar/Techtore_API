using Microsoft.AspNetCore.Mvc;

namespace Techtore_API.Controllers
{
    public class ReviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
