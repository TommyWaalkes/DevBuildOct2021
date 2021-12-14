using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 999000, 100000, 743022, 453202, 10, 949, 3764, 2942, 50, 99, 100, 32 };
            //int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };
            Console.WriteLine("Nums Question 1");
            int min = nums.Min();
            Console.WriteLine(min);
            Console.WriteLine();
            Console.WriteLine("Nums Question 2");
            int max = nums.Max();
            Console.WriteLine(max);
            Console.WriteLine();
            Console.WriteLine("Nums Question 3");
            List<int> numsUnder10000 = nums.Where(x => x < 10000).ToList();
           // numsUnder10000.ToArray();
            int numsUnder1000Max = numsUnder10000.Max();
            Console.WriteLine(numsUnder1000Max);
            Console.WriteLine();

            Console.WriteLine("Nums Question 4");
            int[] numsInRange = nums.Where(x => x >= 10 && x <= 100).ToArray();
            //numsInRange.ToList();
            PrintNums(numsInRange);
            Console.WriteLine();
            Console.WriteLine("Nums Question 5");
            List<int> bigRangedNums = nums.Where(x => x <= 999999 && x >= 100000).ToList();
            PrintNums(bigRangedNums.ToArray());
            Console.WriteLine();

            Console.WriteLine("Nums Question 6");
            int count = nums.Where(x => x % 2 == 0).Count();
            Console.WriteLine("Even nums count: " + count);
            Console.WriteLine("---------------------------------------");
            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));
            students.Add(new Student("Jimmy", 54));
            students.Add(new Student("Eugene", 32));
            students.Add(new Student("Erin", 27));
            students.Add(new Student("Oscar", 77));
            students.Add(new Student("Ivan", 11));
            students.Add(new Student("Ulysses", 1900));


            Console.WriteLine("Student Question 1");
            List<Student> drinkingAged = students.Where(s => s.Age >= 21).ToList();
            PrintStudents(drinkingAged.ToArray());
            Console.WriteLine();
            Console.WriteLine("Student Question 2");
            string oldestName = students.Where(x => x.Age == students.Max(x => x.Age)).First().ToString();
            Console.WriteLine(oldestName);
            Console.WriteLine();

            Console.WriteLine("Student Question 3");
            int youngestAge = students.Min(x => x.Age);
            List<Student> youngest = students.Where(x => x.Age == youngestAge).ToList();
            PrintStudents(youngest.ToArray());
            Console.WriteLine();

            Console.WriteLine("Student Question 4");
            Student oldestUnder25 = students.Where(x => x.Age < 25).OrderBy(x => x.Age).Last();
            Console.WriteLine(oldestUnder25);
            Console.WriteLine();

            Console.WriteLine("Student Question 5");
            List<Student> drinkingAgedAndEven = drinkingAged.Where(x => x.Age % 2 == 0).ToList();
            PrintStudents(drinkingAgedAndEven.ToArray());

            Console.WriteLine();
            Console.WriteLine("Student Question 6");
            List<Student> teenagers = students.Where(x => x.Age >= 13 && x.Age <= 19).ToList();
            PrintStudents(teenagers.ToArray());

            Console.WriteLine();
            Console.WriteLine("Student Question 7");
            string vowels = "AEIOUaeiou";
            List<Student> vowelNames = students.Where(x => vowels.Contains(x.Name[0])).ToList();
            PrintStudents(vowelNames.ToArray());
        }

        public static void PrintNums (int[] nums)
        {
            foreach(int num in nums)
            {
                Console.WriteLine(num);
            }
        }

        public static void PrintStudents(Student[] students)
        {
            foreach(Student s in students)
            {
                //Console.WriteLine("Name: " + s.Name);
                //Console.WriteLine("Age: " + s.Age);
                Console.WriteLine(s);
                Console.WriteLine();
            }
        }
    }
}
