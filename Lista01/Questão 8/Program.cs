using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(x / 100 + " cédula(s) de 100 reais");
            x = x % 100;
            Console.WriteLine(x / 50 + " cédula(s) de 50 reais");
            x = x % 50;
            Console.WriteLine(x / 10 + " cédula(s) de 10 reais");
            x = x % 10;
            Console.WriteLine(x / 5 + " cédula(s) de 5 reais");
            x = x % 5;
            Console.WriteLine(x / 2 + " cédula(s) de 2 reais");
            x = x % 2;
            Console.WriteLine(x / 1 + " cédula(s) de 1 reais");
        }
    }
}
