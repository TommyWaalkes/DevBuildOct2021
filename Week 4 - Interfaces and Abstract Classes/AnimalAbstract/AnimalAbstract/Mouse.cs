using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAbstract
{
    //Mouse will only eat plants 
    //Mice dont need many daily calories
    class Mouse : Animal
    {
        //Base calls the parent's version of whatever is being used 
        //In this it is passing data up to the parent constructor 
        public Mouse() : base(120, FoodType.Plants)
        {

        }

        public override void Eat(Food food)
        {
            //Mice's bodies are very efficent 
            //They double the calories that they eat 
            if (EdibleFoods.Contains(food.FoodType))
            {
                CurrentCalories += food.Calories * 2;
            }
            else
            {
                Console.WriteLine("The mouse could not eat that");
                Console.WriteLine("Mice may only eat plants");
            }
        }
    }
}
