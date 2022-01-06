using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatsAPIDapper
{
    public class Cat
    {
        [Key]
        public int Id { get; set; }
        public string fName { get; set; }
        public bool IsDeclawed { get; set; }
        public int Age { get; set; }
    }
}
