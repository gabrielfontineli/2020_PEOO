using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 30; x++)
            {
                Console.Write($"{x} ");
                if (x % 3 == 0) Console.Write($"{x + (x - 1) + (x - 2)} ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
