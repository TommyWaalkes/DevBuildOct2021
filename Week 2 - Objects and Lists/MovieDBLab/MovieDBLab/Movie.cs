using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDBLab
{
    class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }

        public Movie(string Title, string Category)
        {
            this.Title = Title;
            this.Category = Category;
        }
    }
}
