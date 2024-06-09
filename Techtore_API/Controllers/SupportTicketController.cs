using Microsoft.AspNetCore.Mvc;

namespace Techtore_API.Controllers
{
    public class SupportTicketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
