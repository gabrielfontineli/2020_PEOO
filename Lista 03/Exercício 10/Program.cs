using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            string s = "A";
            if (x > 15 && s != "A") Console.WriteLine(1); //
            if (x < 15 && s != "A") Console.WriteLine(2); //
            if (x < 15 || s == "A") Console.WriteLine(3); // 3
            if (x > 15 || s != "A") Console.WriteLine(4); //
            if (!(x >= 10) && s == "A") Console.WriteLine(5); //
            if (!(x == 10 && s != "A")) Console.WriteLine(6); // 6
            if (!(!(x >= 10) && !(s != "A"))) Console.WriteLine(7); // 7
            if (!(!(x >= 10)) || !(s != "A")) Console.WriteLine(8); // 8
        }
    }
}
