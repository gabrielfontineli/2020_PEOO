using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 26, y = 2;
            Console.WriteLine(x / y); // 13
            Console.WriteLine(x % y); // 0
            y = y + 1;
            Console.WriteLine(x / y); // 8
            Console.WriteLine(x % y); // 2
            y = y + 1;
            Console.WriteLine(2.0 + x / y); // 8
            Console.WriteLine(2.0 + x % y); // 4
            y = y + 1;
            Console.WriteLine(2.0 * x / y); // 10.4
            Console.WriteLine(2.0 * x % y); // 2
        }
    }
}
