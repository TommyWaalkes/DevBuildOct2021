using System;

namespace AnimalAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Chimp c = new Chimp();
            Food meat = new Food(100, FoodType.Meat);
            Food plant = new Food(500, FoodType.Plants);
            c.Eat(plant);
            c.Eat(plant);
            //c.Eat(meat);
            //c.Eat(meat);

            Console.WriteLine("Calories: "+c.CurrentCalories);
            Console.WriteLine("Meat Calories: "+c.MeatCalories);
            Console.WriteLine("Is Full: "+c.EatenEnough);

            //Say we know we're going to need an animal, but we want the user to select which kind of animal 
            //How would we do that?

            //Any animal subclass can be placed in this variable

            //The lab for tonight, you will need to select one of a few different 
            //posibble opponents all in the same family tree. 

            //This is a simplified of what's called the factory pattern 
            Animal a = new Mouse();
            Animal b = new Mouse();

            Console.WriteLine("Which animal would you like to select?");
            string answer = Console.ReadLine();

            if(answer == "chimp")
            {
                a = new Chimp();
            }
            else if(answer == "mouse")
            {
                a = new Mouse();
            }

            Console.WriteLine("Which animal would you like to select?");
            string answer2 = Console.ReadLine();

            if (answer == "chimp")
            {
                b = new Chimp();
            }
            else if (answer == "mouse")
            {
                b = new Mouse();
            }

            a.Eat(plant);
            Console.WriteLine("Calories: " + a.CurrentCalories);

            //Meat Calories is specific to chimp, but the animal variable may not 
            //necesarily be a chimp
            //edit: we fixed the error by putting meat calories into Animal
             Console.WriteLine("Meat Calories: " + a.MeatCalories);
            Console.WriteLine("Is Full: " + a.EatenEnough);
        }
    }
}
