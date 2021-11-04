using System;
using System.Collections.Generic;

namespace Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie m = new Movie("Shrek", Genre.Comedy, 105, "Get out of my swamp", "Donkey shows up", "They visit the dragon");
            // m.PrintInfo();
          //  Console.WriteLine(m);
          //  m.PrintScenes();
            Console.WriteLine();
            VHS d = new VHS("Tommy Boy", Genre.Comedy, 120, "He flunks college", "He sells stuff", "David spade is sarcastic");
            d.PrintInfo();
            Console.WriteLine();
            BlockbusterVideo store = new BlockbusterVideo();

            List<Movie> results = store.SearchByGenres(Genre.Drama);

            foreach(Movie result in results)
            {
                result.PrintInfo();
            }

            //store.GetMovie(4);
        }
    }
}
