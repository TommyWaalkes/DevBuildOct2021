using System;
using System.Collections.Generic;
using System.Text;

namespace TDD
{
    public class Diamond
    {
        public string GetDiamond(char letter)
        {
            if (letter.ToString().ToUpper() == "A")
            {
                return "A";
            }
            else
            {
                string output = "";
                //1) Construct one half the diamond 
                //2) Copy the output string into a new var 
                //3) Reverse the new var 
                //4) Add together the first and second half
                int end = char.ToUpper(letter) - 'A';
                Console.WriteLine(end);
                for(int i = 0; i<=end; i++)
                {
                    int s = int.Parse(('A' + i).ToString());
                    char newLetter = Convert.ToChar(s);

                    if (newLetter == 'A')
                    {
                        output += 'A'; 
                        output += '\n';
                    }
                    else
                    {
                        output += newLetter + GetSpaces(newLetter, Char.ToUpper(letter)) + newLetter + '\n';
                    }
                }
                Console.WriteLine(output);
                return output;
            }
        }

        public string GetSpaces(char currentLetter, char endLetter)
        {
            int diff = endLetter - currentLetter;
            if (diff == 0)
            {
                return "";
            }
            else
            {
                string output = "";
                for (int i = 0; i < diff; i++)
                {
                    output += " ";
                }

                return output;
            }
        }
    }
}
