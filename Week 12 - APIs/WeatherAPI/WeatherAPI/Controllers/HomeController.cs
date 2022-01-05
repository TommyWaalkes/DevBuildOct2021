using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WeatherAPI.Models;

namespace WeatherAPI.Controllers
{
    public class HomeController : Controller
    {
        WeatherDAL wd = new WeatherDAL();
        public IActionResult Index()
        {
            string result = wd.GetDetroit();

            //With return View() if it is passed a single string 
            //.Net tries to treat that string as a view name
            return View("Index",result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
