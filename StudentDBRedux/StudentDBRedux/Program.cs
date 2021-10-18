using System;
using System.Collections.Generic;

namespace StudentDBRedux
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>();
            Students.Add(new Student("Jonesy", "Delaware", "Roasted Duck"));
            Students.Add(new Student("Jane", "Cityvile", "Beat Salad"));
            Students.Add(new Student("Jessie", "Atlanta", "Mac n Cheese"));
            Students.Add(new Student("Jakey", "Town City", "Lamb Kebabs"));

            PrintList(Students);
            string name = GetUserInput("Search the list by student Name");
            Student student = SearchStudentsByName(Students, name);
            Console.WriteLine($"You found : {student.Name}");

            Student s1 = GetRandomStudent(Students);
            Console.WriteLine($"Random Student: {s1.Name}");
            //Linear Search - how humans naturally search lists 
            //Start at the beginning of the list and keep searching each item one by one 
            //For Loops and linear searches go hand in hand 

            //1) Write a loop (usually a for loop) 
            //2) in the loop, pull out the current index 
            //3) if the item at the current index matches our search term, remember that object or index
            //4) Stop searching 

            //C# has LINQ - simplies searching and optimizes 

            bool goOn = true;
            while (goOn == true)
            {
                PrintList(Students);
                string answer = GetUserInput("Please select an index from the list");
                Student stu;
                try
                {
                    //Try catches are still blocks, if you make a variable inside those blocks 
                    //its scope ends at the end of the block
                    //Parsing can throw exceptions so lets put in a try catch block
                    int index = int.Parse(answer);
                    stu = Students[index];
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input to the console was NOT an int");
                    Console.WriteLine("Lets try again");
                    //re-run my loop, how would I do that? 
                    continue;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Input was not a valid index");
                    Console.WriteLine($"Please input a number between 0 and {Students.Count -1}");
                    continue;
                }

                //This loop runs infinitely, so to stop it we MUST use a break 
                while (true)
                {
                    string fact = GetUserInput($"What would you like to learn about {stu.Name}? town or food");

                    //3 cases we care about
                    //1) Food 
                    //2) Town 
                    //3) Anything else

                    if (fact == "town")
                    {
                        Console.WriteLine($"{stu.Name}s hometown is {stu.HomeTown}");
                        break;
                    }
                    else if (fact == "food")
                    {
                        Console.WriteLine($"{stu.Name}s favorite food is {stu.FavoriteFood}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hey I didn't understand that, lets try again");
                    }

                }
            }
        }

        public static void PrintList(List<Student> students)
        {
            for(int i = 0; i <students.Count; i++)
            {
                //we want to print the name and index of our student
                Student s = students[i];
                Console.WriteLine($"{i}: {s.Name}");
                
                //This is valid as well
                //Console.WriteLine($"{i}: {students[i].Name}");
            }
        }

        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().Trim().ToLower();
            return input;
        }

        public static Student SearchStudentsByName(List<Student> students, string name)
        {
            for(int i = 0; i < students.Count; i++)
            {
                Student s = students[i];
                if(s.Name.ToLower() == name.ToLower())
                {
                    return s;
                }
            }

            Console.WriteLine($"No student with the name {name} was found");
            
            //null means nothing, it is how we represent an empty object 
            //and in searches returning null means nothing was found like -1 with indexes. 
            //Null comes from the latin word Nihil, which means nothing
            return null;
        }

        public static Student GetRandomStudent(List<Student> students)
        {
            //In coding, true randomness isn't possible, BUT we can simulate it by using 
            //a scrambling algorithm called a hash. Random number generator take in what's a seed
            //a seed sets up the initial value an RNG will return

            //What's going on is that the RNG has a table of numbers that functionally. 
            //Everytime we grab a new number, what we're actually doing is moving to the next spot in 
            //the RNG table. 

            //Creating a Random Object 
            Random rng = new Random();

            //Rolling a random number 
            //Think of this like a dice roll 
            
            //Next has a few overloads, but the main is Next(minValue, maxValue) 
            //Min Value is inclusive 
            //Max Value is exclusive 

            //pick a random index from the list 
            int index = rng.Next(0, students.Count);
            Student s = students[index];
            return s;
        }
    }
}
