﻿using Microsoft.AspNetCore.Mvc;

namespace Lab13George.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}