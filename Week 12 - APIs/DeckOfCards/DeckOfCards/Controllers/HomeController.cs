using DeckOfCards.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DeckOfCards.Controllers
{
    public class HomeController : Controller
    {
        DeckOfCardsDAL cardDAL = new DeckOfCardsDAL();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewDeck()
        {
            Deck d = cardDAL.CreateDeck();
            return View(d);
        }

        public IActionResult DrawCards(int DrawCount, string DeckId)
        {
            Draw d = cardDAL.DrawCards(DeckId, DrawCount);
            return View(d);
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
