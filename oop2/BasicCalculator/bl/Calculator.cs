using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    internal class Calculator
    {
        public int num1;
        public int num2;
        public Calculator()
        {

        }
        public Calculator(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public int add()
        {
            return num1+num2;
        }
        public int multiply()
        {
            return num1 * num2;
        }
        public float divide()
        {
            return num1 / num2;
        }
        

    }
}
