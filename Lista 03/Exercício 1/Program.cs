using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 3;
            double c = 4.0;
            string d = "5";
            Console.WriteLine("a = {0}, b = {1}", a, b); // a = 7, b = 3
            Console.WriteLine("a + b = " + (a + b)); // a + b = 10
            Console.WriteLine("{0}{1}{0}{2}{0}{3}", a, b, c, d); // 737475
            Console.WriteLine("{0} / {1} = {2:0.00}", a + b, c, (a + b) / c); // 10 / 4  = 2.50 
            Console.WriteLine(a + b + (a + b) / b + c); // 17
        }
    }
}
