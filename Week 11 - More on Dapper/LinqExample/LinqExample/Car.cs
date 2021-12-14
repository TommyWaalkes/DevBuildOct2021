using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExample
{
    public enum Color
    {
        Red,
        Blue, 
        Yellow, 
        Tan, 
        Black
    }
    class Car
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string Name, Color Color, string Make, string Model, int Year)
        {
            this.Name = Name;
            this.Color = Color;
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
        }
    }
}
