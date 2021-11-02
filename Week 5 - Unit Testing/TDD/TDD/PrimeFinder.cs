using System;
using System.Collections.Generic;
using System.Text;

namespace TDD
{
    class PrimeFinder
    {
        public string EvenOddOrPrime(int num)
        {
            if(num == 1)
            {
                return "odd";
            }
            if(num == 2)
            {
                return "prime";
            }
            if (num % 2 == 0)
            {
                return "even";
            }
            else
            {
                //We can ignore even numbers for checking for prime
                //1 goes into ever number 
                //2 goes into every even number and even numbers can't be prime 
                //plus we checked for evens
                for(int i = 3; i < num; i += 2)
                {
                    if(num % i == 0)
                    {
                        return "odd";
                    }
                }

                //The number is prime if we get through the full for loop
                return "prime";
            }
        }
    }
}
