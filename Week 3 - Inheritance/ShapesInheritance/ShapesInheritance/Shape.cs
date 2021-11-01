using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesInheritance
{
    class Shape
    {
        //For properties try to think of data common to ALL shapes
        public double Length { get; set; }
        public double Width { get; set; }
        //We need to swap these to methods since we know methods can be customized 
        //But aren't about Lambdas 

        //To show off both methods of passing around formulas 
        //I will do area as the method 
        //and perimeter as the lambda 
        //In the real world I would be consistent
       // public virtual double Area => Length * Width;
        public virtual double Perimeter => 2 * Length + 2 * Width;

        //The children of shape MUST fulfill the promise that Shape made: 
        //All shapes must get a Length and Width at Creation time
        public Shape(double Length, double Width)
        {
            this.Length = Length;
            this.Width = Width;
        }

        //We use override to customize our parent's methods
        //ToString comes from the grandparent of all objects 
        //Any object can override it 
        public override string ToString()
        {
            string output = $"Width: {Width}\n";
            output += $"Length: {Length}\n";
            output += $"Area: {GetArea()}\n";
            output += $"Perimeter: {Perimeter}";
            return output;
        }

        //Since GetArea and GetPerimeter are virtual my children may override them if need be 
        public virtual double GetArea()
        {
            return Length * Width;
        }

        //public virtual double GetPerimeter()
        //{
        //    return 2 * Length + 2 * Width;
        //}
    }
}
