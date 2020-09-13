using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_19
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine($"Tabuada de {x}");
                for (int y = 1; y <=10; y++)
                {
                    Console.WriteLine($"{x} x {y} = {x * y}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
