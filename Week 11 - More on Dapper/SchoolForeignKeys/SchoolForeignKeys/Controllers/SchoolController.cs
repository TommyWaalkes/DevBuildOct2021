using Microsoft.AspNetCore.Mvc;
using SchoolForeignKeys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolForeignKeys.Controllers
{
    //To tell .Net to treat a class as a controller we subclass the controller class
    public class SchoolController : Controller
    {
        SchoolDAL db = new SchoolDAL();
        public IActionResult Index()
        {
            List<Teacher> teachers = db.GetTeachers();
            return View(teachers);
        }
        public IActionResult Teacher(int id)
        {
            Teacher t = db.GetTeacher(id);
            return View(t);
        }

        public IActionResult TeacherSubjects()
        {
            List<TeacherSubject> teacherSubjects = db.GetTeacherSubjects();
            return View(teacherSubjects);
        }
    }
}
