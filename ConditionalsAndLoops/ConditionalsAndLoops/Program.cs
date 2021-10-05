using System;

namespace ConditionalsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) If Statements 
            //2) Switch Statements 
            //3) For Loops 
            //4) While Loops

            //Check for even or odd
            Console.WriteLine("Please input an integer");
            
            //Method calls start on the inside and work theier way out 
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is even!");

            }
            else
            {
                Console.WriteLine($"{x} is odd!");
            }

            Console.WriteLine();
            Console.WriteLine("Checking even and odd with a switch");
            switch (x % 2 ==0)
            {
                //Cases won't allow boolean expression
                //case > 0:
                //  Console.WriteLine("x is even");
                //  break;
                case true:
                    Console.WriteLine($"{x} is even");
                    break;
                case false:
                    Console.WriteLine($"{x} is odd");
                    break;
            }

            //if (x % 2 == 1) <-- this how you check oddness

            Console.WriteLine();

            Console.WriteLine("If Else Statement Example");
            Console.WriteLine("Are you cold, warm, or comfortable?");

            string answer = Console.ReadLine().ToLower();

            if (answer == "warm")
            {
                Console.WriteLine("Here's an ice pack and popscile");
            }
            else if(answer == "cold")
            {
                Console.WriteLine("Here's a sweater and a hot bowl of soup");
            }
            else if(answer == "comfortable")
            {
                Console.WriteLine("Glad you are okay!");
            }
            else
            {
                Console.WriteLine("I'm sorry I didn't understand that");
            }

            Console.WriteLine("Switch Statement Example:");

            switch (answer)
            {
                case "warm":
                    Console.WriteLine("You should really cool off");
                    break;
                case "cold":
                    Console.WriteLine("Me too");
                    break;
                case "comfortable":
                    Console.WriteLine("Well that's Great!");
                    break;
                default:
                    Console.WriteLine("Sorry I didn't understand the second time either");
                    break;
            }
            //Parts of a for loop
            //1) loop variable - only useable in the loop - usually meant to track whether the loop should end
            //2) end condition - boolean express run at the end of each iteration to decide whether or not to keep running the loop 
            //3) post loop code - this gets run at the end of each iteration - usually i++ or i--
            Console.WriteLine();
            Console.WriteLine("For Loop Example:");

            //why start i at 0 and not 1? 
            //In computer science arrays and collections are indexed starting at 0
            //Someone made a decision when making C in the 70s or 80s and we're stuck with 
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //in for loops each part of the loop is technically optional 
            //But if any parts are missing it generally going to break the loop 
            //for (; ; )
            //{
            //    Console.WriteLine("hii");
            //}

            Console.WriteLine("While Loop Example");

            bool goOn = true;

            //While loops lets you use any valid condition BUT 
            //you must remember to stop come time 
            //Therefore while loops are much more likely to go infinite 
            while(goOn == true)
            {
                Console.WriteLine("Would you like the while loop to stop? y/n");
                string response = Console.ReadLine().ToLower();
               // Console.WriteLine(response);

                if(response == "y")
                {
                    Console.WriteLine("Good Bye!");
                    break;
                }
                else if (response == "n")
                {
                    Console.WriteLine("Continuing the loop");
                }
                else
                {
                    Console.WriteLine("I'm sorry I didn't understand that");
                    Console.WriteLine("let's try again");
                }
            }

            Console.WriteLine();
            Console.WriteLine("While Loop with numbers");
            //This is the same as a for loop
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }

        }
    }
}
