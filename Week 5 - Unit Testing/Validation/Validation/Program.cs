using System;

namespace Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 20, 31, 44 };

            Console.WriteLine("Please select a num to print from the array:");
            int input = -1;

            //The out keyword stores the result of the trypare into the input variable 
            //Streamlines the conversion process and prevents any parsing from being thrown
            //Test out try parse, mess with, but feel free to use whatever method the most sense to you: 
            //Parse
            //TryParse 
            //ConvertTo
            bool success = int.TryParse(Console.ReadLine(), out input);

            if (success)
            {
                //try - this is the code we think may throw an exception 
                //catch - if an exception, react to it 
                try
                {
                    int num = nums[input];
                    Console.WriteLine(num);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine($"That input was not within the valid range: 0 to {nums.Length}");
                }
            }
            else
            {
                Console.WriteLine("That was not a valid int");
            }
        }
    }
}
