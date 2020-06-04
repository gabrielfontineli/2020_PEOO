using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -10;
            int b = 3;
            double c = 3.0;
            if (a < 0) Console.WriteLine(1); // 1
            if (a < 0 && b > 5) Console.WriteLine(2); //
            if (!(a < 0) && b > 5) Console.WriteLine(3); // 
            if (!(a > 0 || b < c)) Console.WriteLine(4); // 4
            if (!(!(a >= -10) && !(b <= 5))) Console.WriteLine(5); // 5
        }
    }
}
