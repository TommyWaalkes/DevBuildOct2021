using DapperForeignKeys.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DapperForeignKeys.Controllers
{
    public class HomeController : Controller
    {
        public SchoolDAL db = new SchoolDAL();
        public IActionResult Index()
        {
            StudentTeacherViewModel vm = new StudentTeacherViewModel();
            vm.Teacher = db.GetTeacher(1);
            vm.Students = db.GetStudentsByTeacher(1);
            return View(vm);
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
