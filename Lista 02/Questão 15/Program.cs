using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três valores:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int maior = a; 
            if (b > maior) maior = c;
            if (c > maior) maior = c;

            int menor = a;
            if (b < menor) menor = b;
            if (c < menor) menor = c;

            Console.WriteLine($"{menor}, {((a+b+c) - (maior+menor))}, {maior}");
            Console.ReadKey();

        }
    }
}
