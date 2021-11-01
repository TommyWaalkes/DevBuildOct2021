using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAbstract
{
    public enum FoodType
    {
        Meat,
        Plants
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
