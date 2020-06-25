using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 420;
            int b = 2;
            while (x > 0)
            {
                if (x % b == 0)
                {
                    Console.WriteLine(b);
                    x = x / b;
                }
                else b++;
            }
            Console.ReadKey();
        }
        /*
        2
        2
        3
        5
        7
         */
    }
}
