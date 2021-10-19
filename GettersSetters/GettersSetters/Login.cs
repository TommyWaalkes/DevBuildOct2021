using System;
using System.Collections.Generic;
using System.Text;

namespace GettersSetters
{
    class Login
    {
        //This is an older pattern for managing variables
        //The public property manage access to the private variable
        //You only need this pattern if you wish to hide access to a piece of data
        //Normal day to day stuff, keep it simple, just do gets and sets 
        private string password = "hi"; 
        
        //The Value keyword is used primarily in setters 
        //Value means the value I am trying to set the property to 
        //Think of value like a parameter from a method
        public string Password { get { return password; } 
            set {
                //Commonly you will put validation directly in the setter 
                //Main use case for customizing setter is validation 
                if (value.Length >= 7)
                {
                    password = value.ToUpper();
                }
            
            } }

        //This is the standard pattern controlling access to a variable
        private string userName = "";
        public string UserName { get { return userName; } set { userName = value; } }


    }
}
