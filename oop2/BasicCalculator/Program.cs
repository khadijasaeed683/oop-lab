using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation you want to perform (+,*,/): ");
            Calculator cal = new Calculator(num1, num2);
            string ch = Console.ReadLine();
            if(ch=="+")
            {
                Console.WriteLine(cal.add());
                Console.ReadLine();
            }
            if(ch=="*")
            {
                Console.WriteLine(cal.multiply());
                Console.ReadLine();
            }
           




        }
    }
}
