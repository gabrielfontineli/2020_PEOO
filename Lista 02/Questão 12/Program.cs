using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores inteiros separados por um operador +, -, * ou / ");
            char[] c = { '+', '-', '*', '/' };
            string x = Console.ReadLine();
            string[] s = x.Split(c);
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);

            if (x.Contains('+')) Console.WriteLine(a + b);
            else if (x.Contains('-')) Console.WriteLine(a - b);
            else if (x.Contains('*')) Console.WriteLine(a * b);
            else Console.WriteLine(a / b);
            Console.ReadKey();
        }
    }
}
