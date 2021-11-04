using System;

namespace StudyHall
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is what calling constructor looks like 
            Movie m = new Movie("Home Alone", 100, 5);

            //This is how you call an object's methods 
            m.RateMovie();

            //This is what calling a property outside the class
            Console.WriteLine(m.Rating);

            //This lets the user put in whatever title they
            Movie m2 = new Movie();
            Console.WriteLine("What is your movie's Title?");
            m2.Title = Console.ReadLine();
        }
    }
}
