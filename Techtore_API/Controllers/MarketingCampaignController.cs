﻿using Microsoft.AspNetCore.Mvc;

namespace Techtore_API.Controllers
{
    public class MarketingCampaignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}