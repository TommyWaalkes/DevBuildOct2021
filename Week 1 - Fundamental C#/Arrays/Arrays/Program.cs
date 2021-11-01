using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //if you master array syntax, then you are not far from being able to use 
            //many C# collections, they will use arraylike syntax 
            int[] ages = new int[5];
            ages[0] = 9;
            ages[1] = 77;
            ages[2] = 45;
            ages[3] = 32;
            ages[4] = 24;

            int sum = 0; 
            for(int i = 0; i < ages.Length; i++)
            {
                //I acts as our tracker for the index in our array
                //put another way, this is how we know where we currently inside our array
                int age = ages[i];
                Console.WriteLine(age);

                sum += age;
            }

            double average = sum / ages.Length;
            Console.WriteLine($"Average: "+ average);

            //you can put ints into double arrays (and most number arrays)
            double[] grades = {100, 88.5, 79.1, 92.3 };

            //When you print an array, C# gives the array's type but NOT it's contents 
            Console.WriteLine(grades);

            Console.WriteLine("ForEach Loop Example");
            foreach(double grade in grades)
            {
                Console.WriteLine(grade);
            }

            Console.WriteLine("You can grab from an array via individual indexes");
           
            //This gives use the value of index 0 but not a reference
            double g = grades[0];
            Console.WriteLine(g);

            //Updating index 0 
            //Commonly called overwriting an index 
            grades[0] = 75;
            Console.WriteLine("Updated index 0");
            foreach (double grade in grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
