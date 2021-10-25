using System;

namespace Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie m = new Movie("Shrek", Genre.Comedy, 105, "Get out of my swamp", "Donkey shows up", "They visit the dragon");
            // m.PrintInfo();
            Console.WriteLine(m);
            m.PrintScenes();

            VHS d = new VHS("Tommy Boy", Genre.Comedy, 120, "He flunks college", "He sells stuff", "David spade is sarcastic");

            while (true)
            {
                d.Play();
            }
        }
    }
}
