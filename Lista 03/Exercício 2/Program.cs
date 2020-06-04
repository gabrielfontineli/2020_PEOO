using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {


            int a, b; double c; string d;
            a = 8;
            b = 3;
            c = 4.0;
            d = "5";
            Console.WriteLine("a = " + a + ", b = " + b); // a = 8, b = 3
            Console.WriteLine("a / b = {0}", a / b); // a/b = 2
            Console.WriteLine("{0}{1}{0}{2}{0}{3}", a, b, c, d); // 838485
            Console.WriteLine("{0} / {1} = {2:0.00}", a + c, b, (a + c) / b); // 12 / 3 = 4.00
            Console.WriteLine(a + c + (a + a) / b + c); // 21
        }
    }
}
