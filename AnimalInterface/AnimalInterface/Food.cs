using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalInterface
{
    public enum FoodType
    {
        Meat,
        Plant
    }
    class Food
    {
        public int Calories { get; set; }
        public FoodType FoodType { get; set; }

        public Food(int Calories, FoodType FoodType)
        {
            this.Calories = Calories;
            this.FoodType = FoodType;
        }

    }
}
