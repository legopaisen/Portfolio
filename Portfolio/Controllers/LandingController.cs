﻿using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class LandingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
