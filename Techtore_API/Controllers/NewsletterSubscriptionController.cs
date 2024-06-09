using Microsoft.AspNetCore.Mvc;

namespace Techtore_API.Controllers
{
    public class NewsletterSubscriptionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
