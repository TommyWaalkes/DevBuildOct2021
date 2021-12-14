using System;
using System.Collections.Generic;
using System.Text;

namespace LinqLab
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age; 
        }

        //Why override to string? 
        //Allows us to a) keep the printout student consistent b) print our student objects directly 
        public override string ToString()
        {
            string output = "Name: " + Name + "\n" +
                 "Age: " + Age;
            return output;
        }
    }
}
