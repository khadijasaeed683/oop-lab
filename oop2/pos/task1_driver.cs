using pos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction trans = new Transaction();
            trans.ProductName = "khadija";
            trans.Amount = 234f;
            trans.time = "12:11";
            trans.date = "1,2,2";
            Console.WriteLine($"name is {trans.ProductName}");
            Console.WriteLine($"price is {trans.Amount}");
            Console.WriteLine($"time is {trans.date}");
            Transaction trans1 = new Transaction(trans);
          
            trans1.ProductName = "fiza";
            Console.WriteLine($"name of copy  is {trans1.ProductName}");
            Console.WriteLine($"price is {trans1.Amount}");
            Console.WriteLine($"time is {trans1.date}");
            Console.ReadLine();
        }
        
    }
}
