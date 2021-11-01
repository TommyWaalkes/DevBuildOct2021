using System;
using System.Collections.Generic;

namespace MovieDBLab
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieDB db = new MovieDB();
            List<Movie> movies = db.GetMoviesByCategory("fgsdfgsdgsd");
            Console.WriteLine("Movie Count: " + movies.Count);
            foreach(Movie m in movies)
            {
                Console.WriteLine(m.Title);
            }
        }
    }
}
