using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieAPI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Controllers
{
    public class HomeController : Controller
    {
        MovieDAL md = new MovieDAL();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Results(string title)
        {
            SearchParent r = new SearchParent();
            r = md.SearchMoviesByTitle(title);

            return View(r);

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
