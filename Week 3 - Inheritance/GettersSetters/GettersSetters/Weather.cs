using System;
using System.Collections.Generic;
using System.Text;

namespace GettersSetters
{
    class Weather
    {
        public double TempF { get; set; } = 0; 

        //So tempC listens to TempF 
        //Meaning whenever tempF changes, the listener runs the formula for TempC automatically
        //This is never going to be critical or on any tests, BUT it is helpful trick 
        //Hooking up Lambdas/Listener is a relatively new feature in C# 
        //Most useful for formulas 

        //Lambda Expression 
        public double TempC => (TempF - 32) * 5 / 9;
    }
}
