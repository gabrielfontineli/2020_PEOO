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
            int k = 10;
            while (k < 30)
            {
                Console.WriteLine(k);
                k += 2;
            }
            Console.WriteLine(k);
            Console.ReadKey();
            
            /*
            10
            12
            14
            16
            18
            20
            22
            24
            26
            28
            30
            */
        }
    }
}
