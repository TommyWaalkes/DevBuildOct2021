using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleAbstract
{
    //Subclassing an abstract class is the same as a concrete class
    //Most children of abstract classes are concrete
    class Car : Vehicle
    {
        //This is the same idea as with concrete classes and their constructors
        public Car(int MaxGas, double Mileage, int X, int Y) : base(MaxGas, Mileage, X, Y, 100)
        {

        }

        public override void Drive()
        {
            //This is an exception that acts as a reminder to programmer that a method 
            //Hasn't been coded yet. Think of it at a large scale. 
            //throw new NotImplementedException();

            if (CurrentGas > 0)
            {
                CurrentGas--;
                Mileage += MilesPerGallon;
                X++;
                Y++;
                PrintInfo();
            }
        }
    }
}
