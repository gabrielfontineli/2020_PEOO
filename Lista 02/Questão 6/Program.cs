using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três valores inteiros");
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());

            int maior = x1;
            if (x2 > maior) maior = x2;
            if (x3 > maior) maior = x3;
            int menor = x2;
            if (x1 < menor) menor = x1;
            if (x3 < menor) menor = x3;

            Console.WriteLine($"A soma do maior com o menor número é {maior + menor}.");
            Console.ReadKey();

        }
    }
}
