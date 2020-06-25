using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 20;
            while (k >= 10)
            {
                Console.WriteLine(k);
                k--;
            }
            Console.ReadKey();

            /*
            19
            18
            17
            16
            15 
            14
            13
            12
            11
            10 
            */
        }
    }
}
