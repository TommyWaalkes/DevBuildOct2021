using System;

namespace Exponents
{
    class Program
    {
        static void Main()
        {
            bool goOn = true;

            while (goOn == true)
            {
                //double nesting for loops is okay but discouraged since its hard to work with 

                //Anything beyond double nesting is a bad idea 
                for (int j = 0; j < 10; j++)
                {
                    //when j = 0, the i loop runs 0 to 9 times

                    //best way to find the number of times the 2 loops run: 
                    //Multiply the end conditions by each IE 10*10 
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(i*j);
                    }
                }



                string input = Prompt("Please input a number to square ");
                int num = int.Parse(input);

                bool goodNum = RangeCheck(0, 1290, num);

                if (goodNum == true)
                {
                    for (int i = 1; i <= num; i++)
                    {
                        Console.WriteLine($"Number: {i}");
                        Console.WriteLine($"Square: {i * i}");
                        Console.WriteLine($"Cube: {i * i * i}");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Let's try again");
                    
                    //Continue skips us to the next run of the loop
                    continue;
                }

                goOn = Continue();
            }
        }

        public static bool RangeCheck(int min, int max, int num)
        {
            if(num >= min && num <= max)
            {
                return true;
            }
            else if (num < min)
            {
                Console.WriteLine("That number is too small");
                Console.WriteLine($"Please input a number between {min} and {max}");
                return false;
            }
            else
            {
                Console.WriteLine("That number is too big");
                Console.WriteLine($"Please input a number between {min} and {max}");
                return false;
            }
        }

        public static string Prompt(string display)
        {
            Console.WriteLine(display);
            string input = Console.ReadLine();
            return input;
        }

        public static bool Continue()
        {
            string answer = Prompt("Would you like to continue? y/n");
            //3 situations - y, n, anything else 

            if(answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Good bye!");
                return false;
            }
            else
            {
                Console.WriteLine("Hey I didn't understand that");
                Console.WriteLine("Lets try that again");
                return Continue();
            }
        }
    }
}
