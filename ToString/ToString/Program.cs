using System;

namespace ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie m = new Movie("Lord of the Rings", "Fantasy", 180);
            Console.WriteLine(m);
        }
    }
}
