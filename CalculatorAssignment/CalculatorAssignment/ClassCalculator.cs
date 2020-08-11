using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAssignment
{
    public class ClassCalculator
    {
       
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Add()
        {
            return Num1 + Num2;
        }
        public int Substract()
        {
            return Num1-Num2;
        }
        public int Multiply()
        {
            return Num1*Num2;
        }
        public int Divide()
        {
            return Num1/Num2;
        }
    }
}
