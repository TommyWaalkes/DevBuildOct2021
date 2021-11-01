using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    //Car acts as a container for our car data 
    //Meaing its heavy on properties, but light on functionality 
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        //No parameters constructor: 
        //This will simply fill in default value for car 
        //to make testing quicker 
        public Car()
        {
            this.Make = "Ford";
            this.Model = "F150";
            this.Year = 2005;
            this.Price = 24000.00m;
        }

        public Car(string Make, string Model, int Year, decimal Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
        }

        public override string ToString()
        {
            string output = $"Make: {Make} \n";
            output += $"Model: {Model} \n";
            output += $"Year: {Year} \n";
            output += $"Price: {Price} \n";
            return output;
        }
    }
}
