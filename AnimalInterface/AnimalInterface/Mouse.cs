using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalInterface
{
    class Mouse : IAnimal
    {
        public int NeededCalories { get; set; } = 120;
        public int CurrentCalories { get; set; } = 0;

        public int CheeseCalories { get; set; } = 100;

        public List<FoodType> edibleFoods { get; set; } = new List<FoodType>();

        public Mouse()
        {
            edibleFoods.Add(FoodType.Plant);

        }
        //To override a method stub 
        //You match the signature, but don't use the override keyword in C# 
        //other languages would use override here, but C# felt like being different
        //Mice have efficent digestion so they double their calories 

        //Food f, that is my method parameter, I am this method MUST get a food to run correctly 
        public void Eat(Food f)
        {
            if (edibleFoods.Contains(f.FoodType))
            {
                CurrentCalories += f.Calories;
            }
            else
            {
                Console.WriteLine("The mouse cannot eat that, mice only eat plants");
            }
        }

        //We can overload methods from interfaces in children 
        //BUT those overloads only exist in the children
        public void Eat()
        {
            Food f = new Food(100, FoodType.Meat);
            CurrentCalories += f.Calories;
        }
    }
}
