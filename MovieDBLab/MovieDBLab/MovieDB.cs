using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDBLab
{
    class MovieDB
    {
        //This how you can give a property an intial value
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public List<string> AcceptedCategories { get; set; } = new List<string>();

        public MovieDB()
        {
            Movies.Add(new Movie("Finding Nemo", "animated"));
            Movies.Add(new Movie("Toy Story", "animated"));
            Movies.Add(new Movie("Alien", "sci-fi"));
            Movies.Add(new Movie("Star Trek", "sci-fi"));
            Movies.Add(new Movie("Dora the Explorer: The Aztec Incident", "drama"));
            Movies.Add(new Movie("A Few Good Men", "drama"));
            AcceptedCategories.Add("drama");
            AcceptedCategories.Add("animated");
            AcceptedCategories.Add("sci-fi");


        }

        //Make a second list 
        //Put each category match into that 2nd list 
        //Return the new list
        public List<Movie> GetMoviesByCategory(string category)
        {
            List<Movie> output = new List<Movie>();
            //if a valid category is input 
            //continue as normal 
            //if not, tell the user and do nothing

            //.Contains checks the list if the parameter matches anything inside it 
            //if a match is found it returns true, else it returns false
            if (AcceptedCategories.Contains(category))
            {
                for (int i = 0; i < Movies.Count; i++)
                {
                    Movie m = Movies[i];

                    //Check if the category matches
                    if (m.Category == category)
                    {
                        output.Add(m);
                    }
                }
            }
            else
            {
                Console.WriteLine($"{category} is not an accepted category");
                Console.WriteLine("Here are the accepted ones: ");

                foreach(string c in AcceptedCategories)
                {
                    Console.WriteLine(c);
                }

                Console.WriteLine("Nothing has been added to the output list");
            }

            return output;
        }
    }
}
