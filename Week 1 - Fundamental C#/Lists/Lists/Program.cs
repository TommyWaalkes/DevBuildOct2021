using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            //Put items into a list 
            //Add puts the new item into a newly made slot at the end of the list. 
            names.Add("Joey");
            names.Add("Phil");
            names.Add("Tommy");

            //Print our list
            //Printing the list variable directly tells us the data type of our list 
            //but NOT its contents, just like arrays
            //We MUST iterate through a list using a loop to see its contents
            Console.WriteLine(names);

            Console.WriteLine("For Loop Example");
            //Lists (and collections) use count 
            //Arrays use length 
            for(int i = 0; i < names.Count; i++)
            {
                string name = names[i];
                Console.WriteLine(name);
            }

            Console.WriteLine("Reverse For Loop");
            for(int i = names.Count -1; i >=0; i--)
            {
                string name = names[i];
                Console.WriteLine(name);
            }

            names[0] = "Jimmy";
            //No index 10 yet exist so this line would cause an error
            // names[10] = "Alex";

            names.Add("Alex");
            Console.WriteLine("Printing after we added Alex");
            for (int i = 0; i < names.Count; i++)
            {
                string name = names[i];
                Console.WriteLine(name);
            }

            string[] names2 = names.ToArray();

            Console.WriteLine("Converted to an array ");
            for(int i = 0; i < names2.Length; i++)
            {
                Console.WriteLine(names2[i]);
            }
        }

        public static void PrintList(List<string> Names)
        {
            for(int i = 0; i < Names.Count; i++)
            {
                Console.WriteLine($"{i}: {Names[i]}");
            }
        }
    }
}
