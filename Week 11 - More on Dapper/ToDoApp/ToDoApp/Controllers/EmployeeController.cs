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
        EmployeeDAL db = new EmployeeDAL();

        public IActionResult Index()
        {
            List<Employee> employees = db.GetEmployees();
            return View(employees);
        }

        public IActionResult Details(int id)
        {
            Employee e = db.GetEmployee(id);
            return View(e);
        }

        public IActionResult CreateEmployee()
        {
            Employee e = new Employee();
            e.Name = "Cotton Hill";
            e.Title = "Retired Vet";
            e.HoursAvailible = 30;
            db.AddEmployee(e);
            return RedirectToAction("Index");
        }
    }
}
