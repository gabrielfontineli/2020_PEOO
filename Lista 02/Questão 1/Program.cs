using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores inteiros");
            int val1 = int.Parse(Console.ReadLine());
            int val2 = int.Parse(Console.ReadLine());
            if (val1 > val2) Console.WriteLine($"Maior = {val1}");
            else if (val2 > val1) Console.WriteLine($"Maior = {val2}");
            else Console.WriteLine("Números Iguais");
        }
    }
}
