using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDAL dbEmployee = new EmployeeDAL();
        ToDoDAL dbToDo = new ToDoDAL();

        public IActionResult Index()
        {
            EmployeeTaskViewModel etvm = new EmployeeTaskViewModel();
            return View(etvm);
        }

        public IActionResult Details(int id)
        {
            Employee e = dbEmployee.GetEmployee(id);
            return View(e);
        }

        public IActionResult CreateEmployee()
        {
            Employee e = new Employee();
            e.Name = "Cotton Hill";
            e.Title = "Retired Vet";
            e.HoursAvailible = 30;
            dbEmployee.AddEmployee(e);
            return RedirectToAction("Index");
        }
    }
}
