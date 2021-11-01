using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //The dictionary takes in 2 data types instead of one 
            //The first will be the key 
            //The second will be the value
            //Values may repeat as much as you wish 
            //But every key may only be used once per dictionary 
            //Keys must be unique
            Dictionary<string, string> homeTowns = new Dictionary<string, string>();

            List<string> students = new List<string>() { "Erin", "Ramone", "James" };

            //For the add method for a dictionary it takes in 2 parameters: 
            //The first is the key 
            //The second is the value 
            homeTowns.Add("Erin", "Texas");
            homeTowns.Add("Ramone", "Toronto Canada");
            homeTowns.Add("James", "South Detroit");
            //homeTowns.Add("James", "London");

            //print the list of students and their indexes 
            PrintList(students);
            // PrintDictionary(homeTowns);

            string response = Prompt("Which student do you wish to learn about? Select by index");
            int pick = int.Parse(response);

            string name = students[pick];
            string home = homeTowns[name];

            Console.WriteLine($"{name}'s home town is {home}");

            
        }

        public static string Prompt(string display)
        {
            Console.WriteLine(display);
            string input = Console.ReadLine();
            return input;
        }

        public static void PrintList(List<string> Names)
        {
            for(int i =0; i < Names.Count; i++)
            {
                Console.WriteLine($"{i}: {Names[i]}");
            }
        }

        public static void PrintDictionary(Dictionary<string, string> dict) { 
            
            //dict.Key is a list of all the keys in the dictionary 
            //We can loop through the keys and use them to see our values
            foreach(string key in dict.Keys)
            {
                Console.WriteLine("Key: " + key);
                string value = dict[key];
                Console.WriteLine("Value: "+ value);
                Console.WriteLine();
            }
        }
    }
}
