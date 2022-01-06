using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RedditAPI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RedditAPI.Controllers
{
    public class HomeController : Controller
    {
        RedditDAL rDAL = new RedditDAL();
        public IActionResult Index()
        {
            Child c = rDAL.GetPost(4);
            return View(c);
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
