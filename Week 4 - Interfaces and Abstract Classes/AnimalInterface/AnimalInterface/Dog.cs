using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalInterface
{
    class Dog : IAnimal
    {
        public int CurrentCalories { get; set; } = 0;
        public int NeededCalories { get; set; } = 800;
        public void Eat(Food f)
        {
            if(f.FoodType == FoodType.Meat)
            {
                CurrentCalories += f.Calories;
            }
        }
    }
}
