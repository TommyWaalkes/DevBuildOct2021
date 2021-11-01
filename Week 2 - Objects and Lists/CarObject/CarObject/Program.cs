using System;

//For classes to see each other 
//The namespace must match 
namespace CarObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objects are good at storing and moving data around, these are often called models
            //Object other job is to contain any functionality or delegate functionality to other objects

            //The main methods job with object is to call and create them 
            //object's job is functionality 

            Car myCar = new Car("Red",5, 10, 20);
            Console.WriteLine($"Intial Gas: {myCar.Gas}");
            Console.WriteLine($"Initial Mileage: {myCar.Mileage}");

            for (int i = 0; i < 1000; i++)
            {
                myCar.Drive();

                //No () that means its a property
                Console.WriteLine($"New Gas: {myCar.Gas}");
                Console.WriteLine($"New Mileage: {myCar.Mileage}");

                //The () means it a method 
                Console.WriteLine($"Miles Left: {myCar.GetMilesLeft()}");
                Console.WriteLine();

                if(myCar.Gas <= 0)
                {
                    break;
                }
            }

        }
    }
}
