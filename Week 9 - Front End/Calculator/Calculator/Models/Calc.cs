using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public enum Operation
    {
        plus, 
        minus, 
        multiply, 
        divide
    }

    //Models are containers for data 
    public class Calc
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public Operation Operation { get; set; }
        public double Result { get; set; }
    }
}
