using System;

namespace AnimalInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            Food meat = new Food(200, FoodType.Meat);

            d.Eat(meat);

            Console.WriteLine(d.CurrentCalories);
            Console.WriteLine(d.NeededCalories);

            //sine Animal is the parent of mouse we can store in an IAnimal variable
            //This is polymorphism, where parent is welcome so is the child 
            //And despite it being of type IAnimal 
            //When a method it will check in the child first
            IAnimal mouse = new Mouse();

            mouse.Eat(meat);

            //Even though Cheese is in mouse, it is not shared with Dog 
            //This is one of the downside of interfaces 
            //Children must supply their own data, it is not shared between classes
           // Console.WriteLine(d.CheeseCalories);
        }
    }
}
