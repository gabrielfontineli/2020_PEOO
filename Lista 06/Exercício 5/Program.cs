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
            int k = 1;
            for (int x = 1; x <= 46; x += k, k++)
                Console.Write($"{x} ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
