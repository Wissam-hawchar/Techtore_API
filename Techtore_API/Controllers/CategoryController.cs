﻿using Microsoft.AspNetCore.Mvc;

namespace Techtore_API.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
