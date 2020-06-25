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
            int a = 10;
            string r = "";
            while (a >= 1)
            {
                r += a+ " ";
                a--;
            }
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
