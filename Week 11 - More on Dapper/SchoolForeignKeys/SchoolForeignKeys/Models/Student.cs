using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolForeignKeys.Models
{
    public class Student
    {
        [Key]
        int Id { get; set; }
        public string FullName { get; set; }
        public float GPA { get; set; }
        public string FavoriteSubject { get; set; }
        public int Age { get; set; }
        //This is the foreign key to our Teachers table 
        //We want to be able to represent the relationship between Student and Teacher tables 
        //This is a many to one relationship, many students to one teacher

        //We can use TaughtBy to fill in our teacher property 
        public int TaughtBy { get; set; }
        public Teacher Teacher { get; set; }
    }
}
