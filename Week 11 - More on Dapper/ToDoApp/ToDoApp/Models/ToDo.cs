using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float HoursNeeded { get; set; }
        public bool IsCompleted { get; set; }
    }
}
