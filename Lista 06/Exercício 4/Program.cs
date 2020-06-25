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
            for (int x = 1; x <= 30; x++)
                if (x % 3 == 0) Console.Write($"{-x} ");
                else Console.Write($"{x} ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
