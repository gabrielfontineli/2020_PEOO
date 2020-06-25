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
            int s = 1;
            for (int k = 6; k > 0; k--)
            {
                Console.WriteLine(k);
                s *= k;
            }
            Console.WriteLine(s);
            Console.ReadKey();
            
            /* 
            6
            6
            5
            5
            4
            4
            3
            3
            2
            2
            1
            1 
            */
        }
    }
}
