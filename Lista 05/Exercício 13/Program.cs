using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_13
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.Write(i);
                for (int j = i + 1; j < 10; j++)
                    Console.Write(" {0}", j);
                Console.WriteLine();
            }
            Console.ReadKey();
            /*
            1 2 3 4 5 6 7 8 9
            2 3 4 5 6 7 8 9
            3 4 5 6 7 8 9 
            4 5 6 7 8 9 
            5 6 7 8 9
            6 7 8 9
            7 8 9
            8 9
            9
             */
        }
    }
}
