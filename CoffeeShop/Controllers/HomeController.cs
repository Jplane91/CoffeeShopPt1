using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MyAction(string button)
        {
            return View("Registration");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View(new PersonModel());
        }


        [HttpPost]
        public IActionResult Registration(PersonModel newUser)
        {
            return RedirectToAction("EnrollUser", newUser);
        }
        public IActionResult EnrollUser(PersonModel user)
        {
            return View(user);
        }
    }
}
