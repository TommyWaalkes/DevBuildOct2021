using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DapperForeignKeys.Models
{
    public class Student{
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public float GPA { get; set; }
        public string FavoriteSubject { get; set; }
        public int Age { get; set; }
        public int TaughtBy { get; set; }
        
        public Teacher Teacher { get; set; }
    }

    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int StartingYear { get; set; }
        public List<Student> Students { get; set; }
    }
}
