using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalAbstract
{
    //Animal will take the animal's current hunger
    //And the children job will be to figure out what that specific animal eats 
    //and needs calorie wise

    //As such we should also create a food class that contain what type of food it is 
    //as well as the calories of that food. 
    abstract class Animal
    {
        public int NeededCalories { get; set; }
        
        //Assume its the start of the day, the animal hasnt eaten yet 
        public int CurrentCalories { get; set; } = 0;

        //We will use this list to check if the animal is allowed to eat a particular food
        public List<FoodType> EdibleFoods { get; set; } = new List<FoodType>();

        //We're making this virtual so we can override in chimp
        public virtual bool EatenEnough => NeededCalories <= CurrentCalories;

        public Animal(int NeededCalories, params FoodType[] EdibleFoods)
        {
            this.NeededCalories = NeededCalories;
            this.EdibleFoods = EdibleFoods.ToList(); 
        }

        //You cannot change returns in overrideable methods 
        public abstract void Eat(Food food);
    }
}
