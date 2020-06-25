using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            for (int k = 1; k <= 30; k++)
            {
                if (k % 3 == 0 || k % 5 == 0)
                {
                    Console.WriteLine(k);
                    s += k;
                }
            }
            Console.WriteLine(s);
            /*
            3
            5
            6
            9
            10
            12
            15
            18
            20
            21
            24
            25
            27
            30
            */
        }
    }
}