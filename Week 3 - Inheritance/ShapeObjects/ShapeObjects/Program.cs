using System;

namespace ShapeObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(10);

            Console.WriteLine("Length: "+s.Length);
            Console.WriteLine("Area: " + s.Area);
            Console.WriteLine("Perimeter: "+s.Perimeter);
            Console.WriteLine();

            //Any I try and treat triangle as a string it calls tostring automatically
            //So for example when I print my triangle tostring kicks in
            //You may also call it for clarity 
            Triangle t = new Triangle(10, 5);
            Console.WriteLine(t.ToString());
            Console.WriteLine(t.Area);
            Console.WriteLine();
            Rectangle r = new Rectangle(20, 10);
            Console.WriteLine(r);
        }
    }
}
