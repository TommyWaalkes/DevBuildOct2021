using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroNet.Models
{
    public class User
    {
        //This is going to be C# Property and that's (mostly) all models will be 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        //No need to make a constructor since C# supplies an empty contructor. 

        //The one case where you will/may need constructors is when you need to convert any kind data into the model 
        //Mostly this happens with APIs 
        //But you also must make an empty as well in that case. 
    }
}
