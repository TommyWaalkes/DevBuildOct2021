using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TDD
{
    class PasswordApp
    {
        public bool Verify(string password)
        {
            bool isLongEnough = false;
            bool notNull = false;
            bool hasLower = false;
            bool hasUpper = false;
            bool hasDigit = false;
            if (password != null)
            {
                notNull = true;
            }
            else
            {
                //If the password is null 
                //return false automatically 
                //since doing the other checks will result in an exception
                return false;
            }


            if (password.Length >= 8)
            {
                isLongEnough = true;
            }

            hasLower = HasLowerCase(password);
            hasUpper = password.Any(char.IsUpper);
            hasDigit = password.Any(char.IsDigit);

            return isLongEnough && notNull && hasLower && hasUpper && hasDigit;
        }

        public bool HasLowerCase(string input)
        {
            //you can do math on chars as each char has a numeric index
            for(char c = 'a'; c<='z'; c++)
            {
                if (input.Contains(c))
                {
                    return true;
                }
            }

            //if we get through the loop, there are no letters
            return false;
        }
    }
}
