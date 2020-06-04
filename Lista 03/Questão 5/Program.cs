using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b; double c;
            a = 10; b = 3; c = 3.0;
            Console.WriteLine(a++ + b * c); // 19
            Console.WriteLine(a % b++ * c); // 6
            Console.WriteLine("{0}/{1} = {2:0.00}", a, b, a / b); // 11/4 = 2.0
            Console.WriteLine("{0}/{1} = {2:0.00}", b, c, b / c); // 4/3 = 1.33
            Console.WriteLine(((a - b) / b - a + b) / c); // -2
        }
    }
}
