using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeObjects
{
    class Square
    {
        //We want the area and perimeter of our square 
        //with squares all four sides are equal 

        //1) Properties - Length, Perimeter, Area 
        //2) Constructor - Set Length via parameters 
        //3) Methods - None are needed if we use the lambdas on the Area and perimeter properties

        public double Length { get; set; }
        public double Perimeter => Length * 4;
        public double Area => Length * Length;

        //The parameter is so we can set the squares length to whatever we want 
        //And it forces us to provide a length 
        public Square(double Length)
        {
            //This.Length is the class' property 
            //Length is the parameter
            //By Length into the parameter we are saying to other programmer 
            //This object's constructor needs a Length 
            this.Length = Length;
        }

        public override string ToString()
        {
            string output = $"Length: {Length}\n";
            output += $"Area: {Area}\n";
            output += $"Perimeter: {Perimeter}";

            return output;
        }
    }
}
