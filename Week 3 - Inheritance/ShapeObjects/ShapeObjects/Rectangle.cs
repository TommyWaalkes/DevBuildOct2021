using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeObjects
{
    class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Area => Length * Width;
        public double Perimeter => 2 * Length + 2 * Width;

        public Rectangle(double Length, double Width)
        {
            this.Length = Length;
            this.Width = Width;
        }

        public override string ToString()
        {
            string output = $"Length: {Length}\n";
            output += $"Width: {Width}\n";
            output += $"Area: {Area}\n";
            output += $"Perimeter: {Perimeter}";

            return output;
        }

    }
}
