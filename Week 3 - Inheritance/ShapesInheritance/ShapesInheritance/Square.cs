using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesInheritance
{
    class Square : Shape
    {
        //so here base(Length, Length) fills in the Length and Width over in the shape class
        public Square(double Length) : base(Length, Length)
        {

        }
    }
}
