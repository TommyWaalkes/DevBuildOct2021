using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperForeignKeys.Models
{
    public class StudentTeacherViewModel
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
