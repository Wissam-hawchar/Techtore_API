﻿using Microsoft.AspNetCore.Mvc;

namespace Techtore_API.Controllers
{
    public class ModeratorActionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
