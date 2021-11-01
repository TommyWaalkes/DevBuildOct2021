using System;
using System.Collections.Generic;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> userNames = new List<string>();
            List<string> passwords = new List<string>();
            Console.WriteLine("Please input a user name between 7 and 12 characters inclusive");
            Console.WriteLine("The user name must have at least one number");
            Console.WriteLine("The user Name must have at least one letter");
            string name = GetUserInput("Please input a valid username");
            bool validName = UserNameCheck(name);
            Console.WriteLine(validName);

        }

        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);

            string input = Console.ReadLine();
            return input;
        }

        public static bool UserNameCheck(string name)
        {
            bool inRange = RangeCheck(7, 12, name.Length);
            bool hasNum = CheckNums(name);
            bool hasLetter = CheckLetters(name);

            return inRange && hasNum && hasLetter;
        }

        public static bool RangeCheck(int min, int max, int num)
        {
            if(num >= min && num <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckNums(string name)
        {
            char[] nums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for(int i = 0; i < nums.Length; i++)
            {
                char num = nums[i];

                if (name.Contains(num))
                {
                    return true;
                }
            }

            //Hey nothing was found lets return false 
            return false;
        }

        public static bool CheckLetters(string input)
        {
            //What's going on here? 
            //All character have a number assigned to them 
            //Therefore C# will allow you to do math on them 
            //When I do C++ that takes me to the next character 
            //in the character table 
            //And letters are all next to each other 
            for(char c = 'A'; c < 'z'; c++)
            {
                //Char.IsLetter is letter takes in a character and returns true if it is a letter 
                //.Contains() takes in a string or char and returns true if the string contains that parameter
                if (char.IsLetter(c) && input.Contains(c))
                {
                    Console.WriteLine(c);
                    return true;
                }
               
            }

            return false;
        }
    }
}
