using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b; double c;
            a = 12; b = 3; c = 3.0;
            Console.WriteLine(a++ - b * c);// 7
            Console.WriteLine(a / b++ * c);// 9
            Console.WriteLine("{0}/{1} = {2:0.00}", a, c, a / c);// 13/3 = 4.33 
            Console.WriteLine("{0}/{1} = {2:0.00}", a, b, a / b);// 13/4 - 3.00
            Console.WriteLine(((a + b) / b - a + c) / b); // 1.5
        }
    }
}
