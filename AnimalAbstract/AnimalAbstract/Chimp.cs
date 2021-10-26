using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAbstract
{
    class Chimp : Animal
    {
        public int MeatCalories { get; set; } = 0;
        public override bool EatenEnough => (CurrentCalories>= NeededCalories) && (MeatCalories >=200);
        public Chimp() : base(1000, FoodType.Meat, FoodType.Plants)
        {

        }

        public override void Eat(Food food)
        {
            if (!EatenEnough)
            {
                CurrentCalories += food.Calories;
                if(food.FoodType == FoodType.Meat)
                {
                    MeatCalories += food.Calories;
                }
            }
        }
    }
}
