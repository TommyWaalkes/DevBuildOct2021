using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make an array of names
            //Grab user input 
            //Try to pass input in as an index to that array 
            string[] names = { "Tommy", "Joey", "Skippy" };
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i}: {names[i]}");
            }

            bool goOn = true;
            while (goOn)
            {
                Console.WriteLine("Please select a name:");
                string input = Console.ReadLine();

                //Our try should contain the lines of code that may throw exceptions
                try
                {
                    //Int.Parse May throw a formatException
                    int pick = int.Parse(input);
                    string name = names[pick];
                    Console.WriteLine(name);
                    break;
                }
                //The catch kicks in if the exception is thrown 
                //When that exception gets thrown the code will skip down to the catch block 
                //Inside the catch, you want to react to that exception 

                //e is a block variable representing the exception 
                //we can use it to get more info about the exception 
                catch (FormatException e)
                {
                    Console.WriteLine("That was an input that cannot be converted into an int");
                    Console.WriteLine("Please try again");
                    //Continue skips to the next run of the loop 
                    //by putting this I am saying as a programmer 
                    //I intend to rerun the loop
                    continue;
                }
                //You can put in as many catch blocks as you want 
                //That you may check for as many exceptions as you need
                catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine("That input was out of range for our array");
                    Console.WriteLine($"Please input a number between 0 and {names.Length -1}");
                    Console.WriteLine("lets try again");

                    //We can use the e variable to get more details on our Exception 

                    //Message is a property that explains the exception 
                    Console.WriteLine(e.Message);

                    //Stack trace explains where in our the exception got through 
                    //it gives us the line numbers 
                    Console.WriteLine(e.StackTrace);
                    continue;
                }

                //Exception in a catch will catch ANY exception
                //Exception is the parent to all other exceptions 
                //Think of this like an else block at the end of a bunch of if elses
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
            }
        }
    }
}
