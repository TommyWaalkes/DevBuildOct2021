using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    class Greeter
    {
        //Make a hello and a goodbye method
        //For hello we take in someone's name 
        //And return a string greeting them 
        //Same idea for goodbye. 

        public string Greet(string name)
        {
           
            throw new Exception();
            //This line is weird
            if(name == "")
            {
                return "Oh a mysterious stranger";
            }
            else if (name.Length < 5)
            {
                return $"Hi {name}";
            }
            else {
                return $"Hello {name}!";
            }
        }

        

    }
}
