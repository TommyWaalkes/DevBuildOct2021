using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    //This is the model for our many to many relationship
    //Each employee can multiple To Dos 
    //Each To Do can have multiple employees
    //Each row in this table links an To do to an employee
    public class Assignment
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ToDoId { get; set; }
        public Employee Employee { get; set; }
        public ToDo ToDo { get; set; }
    }
}
