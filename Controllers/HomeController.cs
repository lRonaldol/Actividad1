﻿using Microsoft.AspNetCore.Mvc;

namespace Trabajo1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MiPerfil()
        {
            return View();
        }
    }
}
