using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstResponsiveWebAppWertz.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstResponsiveWebAppWertz.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Age = 0;
            ViewBag.Name = "";
            return View();
        }

        [HttpPost]
        public IActionResult Index(ResponsiveWebModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Age = model.AgeThisYear();
                ViewBag.Name = model.Name;
            }
            return View(model);
        }
    }
}