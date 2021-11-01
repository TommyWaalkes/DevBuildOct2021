using System;

namespace UsedCarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot cl = new CarLot();
            cl.PrintInventory();
            cl.BuyCar(1);
            Console.WriteLine();
            cl.PrintInventory();
        }
    }
}
