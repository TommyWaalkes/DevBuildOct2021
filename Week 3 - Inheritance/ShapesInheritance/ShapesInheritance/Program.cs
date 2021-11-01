using System;

namespace ShapesInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generally when using inheritance, 
            //You want to make your parent class first 
            //since it dictates how your children will look 

            //Children in C# may only have 1 direct parent, (but as many indirect grand parents as you want) 

            //This is called single inheritance, both C#, Java, and Javascript (but JS) count as single inheritance languages

            //In C and C++, you may have as many as you wish this is called multiple inheritance 

            Shape s = new Shape(20,50);
            Console.WriteLine(s);
            Console.WriteLine();

            Triangle t = new Triangle(20, 50);
            Console.WriteLine(t);
            Console.WriteLine();

            Square q = new Square(10);
            Console.WriteLine(q);
        }
    }
}
