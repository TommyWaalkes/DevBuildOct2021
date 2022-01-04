using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SWAPIExample.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SWAPIExample.Controllers
{
    public class HomeController : Controller
    {
        SWDAL SWAPI = new SWDAL();


        public IActionResult Index()
        {
            PersonPlanetViewModel ppvm = new PersonPlanetViewModel();
            ppvm.Person = SWAPI.GetPerson(80);
            ppvm.Planet = SWAPI.GetPlanet(1);
            return View("index", ppvm);          
        }

        public IActionResult People()
        {
            PeopleSearchResults psr = new PeopleSearchResults();
            psr = SWAPI.GetPeople(1);
            return View(psr);
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
