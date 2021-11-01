using System;

namespace VehicleAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //With abstract classes, you cannot call the constructor directly 
            //It exists only for its children
            //Vehicle v = new Vehicle();

            //This is handy if you don't know which child you'll need ahead of time 
            //This is an example of polymorphism, anywhere my parent is welcome so is my child
            //Vehicle v = new Car(10,0,0,0);

            Car c = new Car(10, 0, 0, 0);
            c.PrintInfo();
            Console.WriteLine();
            Console.WriteLine("Calling Drive");
            c.Drive();

            Boat b = new Boat(40, 0, 0, 0);
            b.PrintInfo();
            Console.WriteLine();
            Console.WriteLine("Calling Drive");
            b.Drive();

            Plane p = new Plane(1000, 0,0,0,0,3);
            p.PrintInfo();
            Console.WriteLine();
            Console.WriteLine("Calling Drive on Plane");
            p.Drive();
            p.Drive();
            p.Drive();
        }
    }
}
