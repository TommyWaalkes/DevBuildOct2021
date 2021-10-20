using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesInheritance
{
    //What's gonna need to change with triangle is the perimeter and area properties
    //In general the child's job is to identify the variable points (which is a fancy of saying 
    //what will be different between the child and parent) and customize itself. 

    //The idea being is that I don't have to rewrite code common to all shapes over and over 
    //I can have it all in one place, BUT my children can take the code as is OR tweak it
    class Triangle : Shape
    {
        // public override double Area => Length * Width / 2;
        public override double Perimeter => Length + Width +(Math.Sqrt(Length*Length + Width*Width));
        //Our parent needs a Length and Width in its constructor
        //Therefore we need to pass it up via the base call
        //If the parent does NOT need any parameter, you do not need to call base
        public Triangle(double Length, double Width) : base(Length, Width)
        {

        }

        //Override allows us to make our own version 
        //it must match the parent method in return type, signature and parameters
        public override double GetArea()
        {
            return Length * Width / 2;
        }
    }
}
