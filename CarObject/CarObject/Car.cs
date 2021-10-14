using System;
using System.Collections.Generic;
using System.Text;

namespace CarObject
{
    class Car
    {
        //Each of these parts are optional
        //when first writing ask yourself what do I need here 
        //if you get it wrong, each of these parts can be easily added, altered, or removed 
        //1) Properties 
        //2) Constructors 
        //3) Methods 

        //You can customize get and set, but the defaults are good most of the time
        public string Color { get; set; }
        public int Mileage { get; set; }
        public int MilesPerGallon { get; set; }
        public int Gas { get; set; }
        public int MaxGas { get; set; }

        //As a programmer I am saying the car MUST have a color, mileage, MPG, and gas value supplied to it
        //This the constructor  V
        public Car(string Color, int Mileage, int MilesPerGallon, int Gas)
        {
            //Next we need to store the parameter inside our properties 
            //This is the main use of the this keyword 

            //when I do this.Gas, I refer to the gas property
            //This keyword is mainly used in constructors for intializing properties
            this.Gas = Gas;
            this.MaxGas = Gas;
            this.Color = Color;
            this.Mileage = Mileage;
            this.MilesPerGallon = MilesPerGallon;
        }

        //Notice there is no Static inside our object
        //Everywhere we call drive get the fixes and improvement we want on our code
        public void Drive()
        {
            if (Gas > 0)
            {
                Mileage++;
                //Decrement gas when we have gone our MPG far IE if MPG is 30 
                //Decrement gas every 30 miles
                if (Mileage % MilesPerGallon == 0)
                {
                    Gas--;
                }
            }
            else
            {
                Console.WriteLine("The Car is out of gas and cannot move");
            }

        }

        public int GetMilesLeft()
        {
            //Calculate the max possible mile the car can travel 
            //And subtract mileage to see, based on our distance travel 
            //how many more miles can we go 
            int mileLeft = (MilesPerGallon * MaxGas) - Mileage;
            return mileLeft;
        }
    }
}
