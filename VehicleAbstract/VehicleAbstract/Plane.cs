using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleAbstract
{
    //Planes deal with 3 dimensional space 
    //Planes are MUCh less fuel efficent than cars or boats
    //Planes are effected by windspeed
    class Plane : Vehicle
    {
        //Add in properties unique to plane
        public int Z { get; set; }
        public bool InFlight { get; set; } = false;
        public int CurrentWindSpeed { get; set; }
        public override double MilesPerGallon => 100000/(Weight/100 * (CurrentWindSpeed + 1));
        public Plane(int MaxGas, double Mileage, int X, int Y, int Z, int CurrentWindSpeed) : base(MaxGas, Mileage, X, Y, 90000)
        {
            this.Z = Z;
            this.CurrentWindSpeed = CurrentWindSpeed;
        }
        public override void Drive()
        {
            if(InFlight == false)
            {
                TakeOff();
            }
            else if(CurrentWindSpeed > 50)
            {
                Console.WriteLine("The wind is too high to safely fly");
                Console.WriteLine("The plane remains grounded");
            }
            else if(CurrentGas>0)
            {
                Console.WriteLine(MilesPerGallon);
                Mileage += MilesPerGallon;
                CurrentGas--;
                X++;
                Y++;
            }

            PrintInfo();
        }

        public void TakeOff()
        {
            //Check that conditions are good: 
            //1) Gas Tank must be full 
            //2) Windspeed must be below 50 
            //3) Must be grounded 

            //If all conditions are met, spend 3 fuel to take off and 
            //increase the Z position 
            //Set inflight to true

            if(CurrentGas == MaxGas && CurrentWindSpeed < 50 && InFlight == false)
            {
                Z++;
                CurrentGas -= 3;
                InFlight = true;
            }
            else
            {
                Console.WriteLine("The conditions are not good");
                Console.WriteLine("The plane did not take off");
            }
        }
    }
}
