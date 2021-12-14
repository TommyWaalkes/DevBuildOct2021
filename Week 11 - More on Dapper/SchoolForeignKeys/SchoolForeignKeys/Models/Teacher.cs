using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolForeignKeys.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int StartingYear { get; set; }
        
        //We want a property to represent all students taught by this teacher
        public List<Student> Students { get; set; }
    }
}
