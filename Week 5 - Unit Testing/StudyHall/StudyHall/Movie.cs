using System;
using System.Collections.Generic;
using System.Text;

namespace StudyHall
{
    class Movie
    {
        //3 possible sections for writing object
        //1) Properties
        //2) Constructor
        //3) Methods 
        //Each is optional, so when first starting on an object 
        //Ask yuorself which parts you will, and adding onto can be done later 
        //As you flesh out your code

        public string Title { get; set; }
        public int RunTime { get; set; }
        public double Rating { get; set; }

        public Movie(string Title, int Runtime, double Rating)
        {
            this.Title = Title;
            this.RunTime = RunTime;
            this.Rating = Rating;
        }

        //.Net loves objects with empty 
        //Constructors overloads are generally a good idea 
        public Movie()
        {

        }

        public void RateMovie()
        {
            Console.WriteLine($"On a scale of 1 to 10, how do you rate {Title}?");
            string input = Console.ReadLine();
            try
            {
                double newRating = double.Parse(input);
                if(newRating >= 1 && newRating <= 10)
                {
                    //Override the old rating property 
                    Rating = newRating;
                }
                else
                {
                    Console.WriteLine("That input was not between 1 and 10");
                    Console.WriteLine("Let's try that again");
                    RateMovie();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Input was not a valid decimal");
                Console.WriteLine("Lets try that again");
                RateMovie();
            }
            }
        }
    }

