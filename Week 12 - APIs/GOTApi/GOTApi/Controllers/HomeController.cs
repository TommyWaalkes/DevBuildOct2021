using GOTApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GOTApi.Controllers
{
    public class HomeController : Controller
    {
        GoTDAL dal = new GoTDAL();
         public IActionResult Index()
        {
            List<Character> characters = new List<Character>();
            characters.Add(dal.GetSpecificCharacter(583));
            characters.Add(dal.GetSpecificCharacter(238));
            characters.Add(dal.GetSpecificCharacter(2));

            return View(characters);
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
