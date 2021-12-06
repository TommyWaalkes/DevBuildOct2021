using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Validation.Models;

namespace Validation.Controllers
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

        public IActionResult Register()
        {
            //This only needs to display the view and nothing else 
            return View();
        }

        [HttpPost]
        public IActionResult Register(Movie m)
        {
            //This tells .Net to check our model against its data annotations 
            //if no rules are violated return true 
            //if any rule is violated return false 
            if (ModelState.IsValid)
            {
                return RedirectToAction("Result", "Home", m);
            }
            else
            {
                return View();
            }

            //There's 2 ways to handle a bad model from a form: redirect an error page or loop back to the form page and display error text (there's a special way to do that)
        }

        public IActionResult Register2()
        {
            //This only needs to display the view and nothing else 
            return View();
        }

        [HttpPost]
        public IActionResult Register2(Movie m)
        {
            //This tells .Net to check our model against its data annotations 
            //if no rules are violated return true 
            //if any rule is violated return false 
            if (ModelState.IsValid)
            {
                return RedirectToAction("Result", "Home", m);
            }
            else
            {
                return View();
            }

            //There's 2 ways to handle a bad model from a form: redirect an error page or loop back to the form page and display error text (there's a special way to do that)
        }


        public IActionResult Result(Movie m)
        {
            return View(m);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
