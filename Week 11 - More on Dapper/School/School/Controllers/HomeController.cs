using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using School.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace School.Controllers
{
    public class HomeController : Controller
    {
        StudentDAL db = new StudentDAL();
        public IActionResult Index()
        {
            List<Student> students = db.GetStudents();
            return View(students);
        }

        //Actions don't always need to be linked to a view, 
        //They can exist to process info or form input
        public IActionResult Create()
        {
            //Normally this model would come from a form, but I wanted to focus the DAL 
            Student stu = new Student();
            stu.fullName = "Tommy Salami";
            stu.GPA = 10.5f;
            stu.Age = 1100;
            stu.favoriteSubject = "History";

            db.AddStudent(stu);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(int id)
        {
            db.DeleteStudent(id);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Update(int id)
        {
            List<Student> students = db.GetStudents();

            //The where allows us to write a sql like query on our list 
            //the x => condition, runs that condition on all elements in our collection 
            //if the condition is true add the element to our output 
            //if not, skip to the next element 
            //This condenses all of the code for a loop into a single line
            //Linq is guess n check 
            Student s = students.Where( x => x.Id == id).ToList().First();
            s.Age++;
            db.UpdateStudent(s);

            return RedirectToAction("Index", "Home");

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
