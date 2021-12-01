using IntroNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IntroNet.Controllers
{
    //Since this is called the home controller 
    //.Net automatically knows this controller is meant to manage the matching view folder. 
    public class HomeController : Controller
    {
        //I usually Delete/Ignore the logger code
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //Each Action must match the name of a view in the Home folder
        //.Net Loves to play matching Games

        //.Net knows a method is an action when you set the return type to IActionResult
        //The result of most actions is a view

        //Return View() - that means pull up the view matching the name of the action
        //BUT if you wish to redirect to another page, you would swap out the return view line 
        //for a return RedirectToAction() which takes 2 parameters,
        //the action you wish to go to and the controller that manages that action

        //Think redirects this way: The controller is your city and the action is your street 
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //I want to 2 new actions: 
        //1) will be a form to allow the user to fill in data for a user model 
        //2) will take in a user model, automatically made from the form, and display its info
        //With step 2 there's some of what I like to call .Net magic, where it will handle thing automatically 

        public IActionResult UserForm()
        {
            //Nothing special needs to be in this action, 
            //we just need to display the view. 
            return View();
        }

        //The user u represents the form data we just collected 
        //We will pass it down to a view and have that view display that info 
        //Later we will learn to how to store and manipulate that user in a database
        public IActionResult Result(User u)
        {
            //We pass the user model to the view so the view can display the user's info.
            return View(u);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
