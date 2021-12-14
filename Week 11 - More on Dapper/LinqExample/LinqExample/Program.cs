using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 12,17,32, 84, 95, 51, 22, 43 };

            //Write a query to find all odd numbers 
            //Any condition is valid in the second part of a Lambda expression

            //by default, Where (and many other linq methods) return an IEnumerable 
            //So we need to convert it into a list
            List<int> odds = nums.Where(n => n % 2 == 1).ToList();
            Console.WriteLine("Method Syntax for finding odds");
            foreach(int odd in odds)
            {
                Console.WriteLine(odd);
            }
            Console.WriteLine();
            Console.WriteLine("Query Syntax for finding odds");
            List<int> odds2 = (from n in nums
                              where n % 2 == 1
                              select n).ToList();
            foreach(int odd in odds2)
            {
                Console.WriteLine(odd);
            }

            //Grab all numbers within a range of 20 to 50 inclusive
            Console.WriteLine("Method syntax for grabbing all nums within a range");
            List<int> numsInRange = nums.Where(x => 20 <= x && x <= 50).ToList();

            foreach(int num in numsInRange)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
            Console.WriteLine("Query Syntax for finding nums within a range");
            List<int> numsInRange2 = (from n in nums
                                    where n >= 20 && n <= 50
                                    select n).ToList();
            foreach (int num in numsInRange2)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
            Console.WriteLine("Counting all even numbers under 50");

            //Count tallies each element that meets the input condition 
            int evensUnder50 = nums.Count(n => n < 50 && n % 2 == 0);
            Console.WriteLine("Even numbers under 50: " + evensUnder50);

            Console.WriteLine();
            Console.WriteLine("Average Method");
            
            //No params means we average the whole list
            double averageOfWholeList = nums.Average();
            Console.WriteLine("Average of the whole list: " + averageOfWholeList);

            //with params we average all numbers that mean our conditions 
            double numsOver40 = nums.Where(n => n >= 40).Average();
            Console.WriteLine("Average of numbers over 40: " + numsOver40);

            //Gives us the total in the whole collection 
            //OR totals all nums meeting a condition
            int total = nums.Sum();
            Console.WriteLine("Total of all nums in our list: "+total);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Car Object Examples");

            List<Car> cars = new List<Car>();
            cars.Add(new Car("Gertrude", Color.Tan, "Ford", "Nova", 2000));
            cars.Add(new Car("Frank", Color.Red, "Ford", "Windstar", 2012));
            cars.Add(new Car("Alvin", Color.Tan, "Toyota", "Camry", 2012));
            cars.Add(new Car("Dutch", Color.Blue, "GM", "Avalon", 1995));
            cars.Add(new Car("Theodore", Color.Red, "Ford", "Brontosaurus", 2001));

            //This line gets us our oldest year
            int oldestYear = cars.Min(x => x.Year);

            //Grab all cars matching that year
            List<Car> oldestCars = cars.Where(x => x.Year == oldestYear).ToList();
            foreach(Car c in oldestCars)
            {
                Console.WriteLine("Name: "+ c.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Grabbing the youngest car");
            int youngestAge = cars.Max(x => x.Year);
            List<Car> youngestCars = cars.Where(x => x.Year == youngestAge).ToList();
            foreach(Car c in youngestCars)
            {
                Console.WriteLine(c.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Search for cars by color");

            List<Car> redCars = cars.Where(x => x.Color == Color.Red).ToList();
            Console.WriteLine("Red Cars:");
            foreach(Car c in redCars)
            {
                Console.WriteLine(c.Name);
            }
        }
    }
}
