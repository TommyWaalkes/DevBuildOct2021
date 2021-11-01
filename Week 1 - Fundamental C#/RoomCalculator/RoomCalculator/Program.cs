using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Prompt the user for length and width and height
            //2) Get user input 3 times and store it 
            //3) Try to parse input into doubles 
            //4) Calculate Area 
            //5) Calcuate Perimeter 
            //6) Calculate Carpet Tiles
            //7) Calculate paint cans (both on the walls and on the perimeter
            //8) Figure if the user wishes to continue Y/N 
            bool goOn = true;

            while (goOn == true)
            {
                Console.WriteLine("Welcome to the GC Room Calculator");
                Console.WriteLine("Please input a length");
                string inputLen = Console.ReadLine();

                Console.WriteLine("Please input a Width");
                string inputWid = Console.ReadLine();

                Console.WriteLine("Please input a Height");
                string inputHeight = Console.ReadLine();

                double length = double.Parse(inputLen);
                double width = double.Parse(inputWid);
                double height = double.Parse(inputHeight);

                double area = length * width;
                double volume = length * width * height;
                double perimeter = 2 * length + 2 * width;

                double carpetTiles = area / 5;
                double paintPerimeter = perimeter / 5;
                double paintWalls = (area + 2 * length * height + 2 * width * height) / 25;

                Console.WriteLine($"Length: {length}");
                Console.WriteLine($"Width: {width}");
                Console.WriteLine($"Height: {height}");
                Console.WriteLine();
                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Volume: {volume}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine();
                Console.WriteLine($"Carpet Tiles: {carpetTiles}");
                Console.WriteLine($"Perimeter Paint Cans: {paintPerimeter}");
                Console.WriteLine($"Paint Cans for Walls: {paintWalls}");
                Console.WriteLine();

                bool askAgain = true;

                while (askAgain == true)
                {
                    Console.WriteLine("Would you like to continue? Y/N");
                    string answer = Console.ReadLine().ToLower();
                    //There possibilities to check for: 
                    //1) Y 
                    //2) N 
                    //3) Anything else

                    if (answer == "y")
                    {
                        askAgain = false;
                        goOn = true;
                    }
                    else if (answer == "n")
                    {
                        askAgain = false;
                        goOn = false;
                        Console.WriteLine("Good Bye!");
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry I didn't understand that ");
                        Console.WriteLine("Let's try that again");
                    }

                }
            }
        }
    }
}
