using System;
using System.Collections.Generic;
using System.Text;

namespace TDD
{
    class NumberToEnglish
    {
        //the job of nums to English will be cutting our number apart 
        //and putting together the resulting English
        public string NumToEnglish(double num)
        {
            if (num < 10)
            {
                string ones = GetOnesPlace(num);
                return ones;
            }
            else if(num < 100)
            {
                string result = GetTensPlace(num);
                return result;
            }
            else
            {
                string result = GetHundredsPlace(num);
                return result;
            }
        }

        public string GetOnesPlace(double num)
        {
            switch (num)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "";
            }
        }

        public string GetTensPlace(double num)
        {
            if (num < 20)
            {
                switch (num)
                {
                    case 10:
                        return "ten";
                    case 11:
                        return "eleven";
                    case 12:
                        return "twelve";
                    case 13:
                        return "thirteen";
                    case 14:
                        return "fourteen";
                    case 15:
                        return "fifteen";
                    case 16:
                        return "sixteen";
                    case 17:
                        return "seventeen";
                    case 18:
                        return "eighteen";
                    case 19:
                        return "nineteen";
                    default:
                        return "";
                }
            }
            else
            {
                //Figure out the value for the tens place 
                //Delegate the ones place to the other method
                double ones = num % 10;
                string onesEnglish = "";
                if (ones != 0)
                {
                    onesEnglish = GetOnesPlace(ones);
                }

                double tens = num - ones;
                string tensEnglish = "";

                switch (tens)
                {
                    case 20:
                        tensEnglish = "twenty";
                        break;
                    case 30:
                        tensEnglish = "thirty";
                        break;
                    case 40:
                        tensEnglish = "fourty";
                        break;
                    case 50:
                        tensEnglish = "fifty";
                        break;
                    case 60:
                        tensEnglish = "sixty";
                        break;
                    case 70:
                        tensEnglish = "seventy";
                        break;
                    case 80:
                        tensEnglish = "eighty";
                        break;
                    case 90:
                        tensEnglish = "ninety";
                        break;

                }
                if (onesEnglish == "" || onesEnglish == "0")
                {
                    return tensEnglish;
                }
                else
                {
                    return tensEnglish + " " + onesEnglish;
                }

            }

        }

        public string GetHundredsPlace(double num)
        {
            double tens = num % 100;
            double hundreds = num - tens;
            string tensEnglish = GetTensPlace(tens);

            //Say we have 500, we'll get a 5 and pass it the ones places method 
            //and once that's done tack on hundred at the end
            double hundredsDigit = hundreds / 100;

            string hundredsEnglish = GetOnesPlace(hundredsDigit);

            return (hundredsEnglish +" hundred " + tensEnglish).Trim();
        }
    }
}
