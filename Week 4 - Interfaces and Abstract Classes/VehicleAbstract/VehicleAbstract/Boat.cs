using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleAbstract
{
    class Boat : Vehicle
    {
        public Boat(int MaxGas, double Mileage, int X, int Y) : base(MaxGas, Mileage, X, Y, 600)
        {

        }
        public override void Drive()
        {
            if(CurrentGas > 0)
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
