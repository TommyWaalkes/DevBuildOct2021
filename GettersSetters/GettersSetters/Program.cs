using System;

namespace GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Login l = new Login();

            l.Password = "tommy";
            Console.WriteLine(l.Password);

            Weather w = new Weather();

            while (true)
            {
                Console.WriteLine("Enter a number in F and I will convert it to C");
                double tempF = double.Parse(Console.ReadLine());
                w.TempF = tempF;

                Console.WriteLine("Temp F: " + w.TempF);
                Console.WriteLine("Temp C: " + w.TempC);
                Console.WriteLine();
            }
        }
    }
}
