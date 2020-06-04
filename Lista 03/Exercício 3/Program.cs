using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 35, y = 5;
            Console.WriteLine(x / y); // 7
            Console.WriteLine(x % y); // 0
            y = y + 1;
            Console.WriteLine(x / y); // 5
            Console.WriteLine(x % y); // 5
            y = y + 1;
            Console.WriteLine(2.0 + x / y); // 7
            Console.WriteLine(2.0 + x % y); // 2
            y = y + 1;
            Console.WriteLine(2.0 * x / y); // 8.75
            Console.WriteLine(2.0 * x % y); // 6
        }
    }
}
