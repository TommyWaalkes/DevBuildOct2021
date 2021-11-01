using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    //Managing and Selling our cars
    //This will store a list of cars 
    //And the user will be allowed to buy or sell their car as well as browse the lot
    class CarLot
    {
        public List<Car> Cars { get; set; } = new List<Car>();

        public CarLot()
        {
            Cars.Add(new Car());
            Cars.Add(new Car("Chevy", "Malibu", 2000, 30000));
            Cars.Add(new UsedCar("Volkswagen", "Bus", 1967, 40000, 250000));
        }

        public void PrintInventory()
        {
            for(int i = 0; i < Cars.Count; i++)
            {
                //We want to print the index for each car along with its make n model
                Car c = Cars[i];
                Console.WriteLine( $"{i}: {c}");
                Console.WriteLine();
            }
        }

        public void BuyCar(int index)
        {
            //Try to get the car at the selected index
            try
            {
                Car c = Cars[index];

                //Let's Remove the car from our list, which we can do based upon index 
                Cars.RemoveAt(index);
                Console.WriteLine($"Congrats you just bought a {c.Make} {c.Model} at {c.Price}");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine($"{index} is not a valid index");
                Console.WriteLine($"Please input an index between 0 and {Cars.Count -1}");
            }
        }
    }
}
