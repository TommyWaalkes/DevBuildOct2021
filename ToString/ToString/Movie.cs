using System;
using System.Collections.Generic;
using System.Text;

namespace ToString
{
    class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Runtime { get; set; }

        public Movie(string Title, string Genre, int Runtime)
        {
            this.Title = Title;
            this.Genre = Genre;
            this.Runtime = Runtime;
        }

        //We can customize how Movie gets coverted to a String
        public override string ToString()
        {
            string output = $"Title: {Title} \n";
            output += $"Genre: {Genre} \n";
            //^this is the same as the following:
           // output = output + $"Genre: {Genre} \n";
            output += $"Run Time: {Runtime}";

            return output;
        }
    }
}
