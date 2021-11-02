using System;
using System.Collections.Generic;
using System.Text;

namespace TDD
{
    class FizzBuzz
    {
        public string GetFizzBuzz(int num)
        {
            //% is modulous and that means return the remainder
            if(num % 5 ==0 && num %3 == 0)
            {
                return "fizzbuzz";
            }
            if (num % 5 == 0)
            {
                return "buzz";
            }
            if(num % 3 == 0)
            {
                return "fizz";
            }
            return "";
        }
    }
}
