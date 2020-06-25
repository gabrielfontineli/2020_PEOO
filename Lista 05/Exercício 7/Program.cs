using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int k = 1; k <= 30; k++)
            {
                if (k % 3 == 0) Console.WriteLine(k);
            }
            Console.ReadKey();

            /* 
             3
             6
             9
            12
            15
            18
            21
            24
            27
            30
            */
        }
    }
}
