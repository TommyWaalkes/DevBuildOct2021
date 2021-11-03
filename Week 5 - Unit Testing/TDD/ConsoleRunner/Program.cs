using System;
using TDD;

namespace ConsoleRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Diamond d = new Diamond();
            Console.WriteLine(d.GetDiamond('C'));
        }
    }
}
