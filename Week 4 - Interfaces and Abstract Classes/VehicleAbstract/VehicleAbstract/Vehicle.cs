using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleAbstract
{
    abstract class Vehicle
    {
        //Vehicle will track its gas, mileage, and position 
        //For methods it will have a virtual PrintInfo, an abstract drive method
        public int MaxGas { get; set; }
        public int CurrentGas { get; set; }
        public double Mileage { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Weight { get; set; }

        public virtual double MilesPerGallon => 1000 / Weight;

        //We not call this directly, BUT it is useful for our children
        public Vehicle(int MaxGas, double Mileage, int X, int Y, int Weight)
        {
            this.MaxGas = MaxGas;

            //Assume we start with a full tank
            this.CurrentGas = MaxGas;
            this.X = X;
            this.Y = Y;
            this.Mileage = Mileage;
            this.Weight = Weight;
        }

        //Abstract method have no body 
        //They are just the "head" of the method 
        //Commonly this is called a method stub 
        //Abstract methods can only be in abstract classes
        public abstract void Drive();

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Remaining Gas: {CurrentGas}/{MaxGas}");
            Console.WriteLine($"Mileage: {Mileage}");
            Console.WriteLine($"Position: X {X}, Y {Y}");
        }

    }
}
