using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeObjects
{
    class Triangle
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double Area => Base * Height / 2;
        public double Perimeter => Base + Height + Math.Sqrt(Base * Base + Height * Height);

        public Triangle(double Base, double Height)
        {
            this.Base = Base;
            this.Height = Height;
        }

        public override string ToString()
        {
            string output = $"Base: {Base}\n";
            output += $"Height: {Height}\n";
            output += $"Area: {Area}\n";
            output += $"Perimeter: {Perimeter}";

            return output;
        }
    }
}
