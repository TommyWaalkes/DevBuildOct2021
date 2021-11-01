using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    class UsedCar :Car
    {
        public double Mileage { get; set; } 

        public UsedCar(string Make, string Model, int Year, decimal Price, double Mileage)
            : base(Make, Model, Year, Price)
        {
            this.Mileage = Mileage;
        }

        //Let's add onto car's version of ToString() 
        public override string ToString()
        {
            //Since we want the parent's version of ToString we'll leave base.ToString in here
            string output = base.ToString();
            output += $"Mileage: {Mileage}";
            return output;
        }
    }
}
