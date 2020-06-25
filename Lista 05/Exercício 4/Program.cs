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
            int k = 10;
            int s = 1;
            while (k < 30)
            {
                Console.WriteLine(k * s);
                k += 2;
                s = -s;
            }
            Console.ReadKey();
            
            /* 
            10
            -12
            14
            -16
            18
            20
            -22
            24
            -26
            28
            */
        }
    }
}
