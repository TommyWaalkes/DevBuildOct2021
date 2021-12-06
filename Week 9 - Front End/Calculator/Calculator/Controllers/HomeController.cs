using Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Controllers
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

        public IActionResult Calculator()
        {
            return View();
        }

        public IActionResult Result(Calc c)
        {
            //string name = "tommy";
            ////You can use C# in controllers to validate 
            //if(name.Length == 50)
            //{

            //}
            double result = 0; 
            if(c.Operation == Operation.plus)
            {
                result = c.Num1 + c.Num2;
            }
            else if (c.Operation == Operation.minus)
            {
                result = c.Num1 - c.Num2;
            }
            else if (c.Operation == Operation.multiply)
            {
                result = c.Num1 * c.Num2;
            }
            else
            {
                result = c.Num1 / c.Num2;
            }
            c.Result = result;
            return View(c);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
