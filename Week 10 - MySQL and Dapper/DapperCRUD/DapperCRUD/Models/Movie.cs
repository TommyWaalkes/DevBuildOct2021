using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCRUD.Models
{
    public class Movie
    {
        //-- ID - required, primary key
        //-- Title - required and max length of 30 characters
        //-- Genre 
        //-- Year - must be between 1880 and 2021
        //-- Runtime

        [Key]
        [Required]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Title { get; set; }

        public string Genre { get; set; }
        [Range(1880, 2021)]
        public int Year { get; set; }
        public int RunTime { get; set; }
    }
}
