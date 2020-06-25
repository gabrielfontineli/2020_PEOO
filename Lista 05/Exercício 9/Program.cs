using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int d = 2;
            for (int k = 1; k <= 10; k++)
            {
                Console.WriteLine("{0}/{1}", n, d);
                n += 2;
                d *= 2;
            }
            Console.ReadKey();
            /*
            2/2
            4/4
            6/8
            8/16
            10/32
            12/64
            14/128
            16/256
            18/512
            20/1024
             */
        }
    }
}
