﻿using Microsoft.AspNetCore.Mvc;

namespace Authorization.VKontakte.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = User.Identity.Name;
            ViewBag.IsAuthenticated = User.Identity.IsAuthenticated;

            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}