using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 102;
            int r;
            string s = "";
            while (x > 0)
            {
                r = x % 2;
                x = x / 2;
                s = r + s;
            }
            Console.WriteLine(s);
            Console.ReadKey();
            /*
            1100110
             */
        }
    }
}
