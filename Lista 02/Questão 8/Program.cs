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
            Console.WriteLine("Digite quatro valores inteiros");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            if ((a != b) && (a != c) && (a != d) && (b != c) && (b != d) && (c != d))
            {
                int maior = a; int menor = a;
                if (b > maior) maior = b; if (b < menor) menor = b;
                if (c > maior) maior = c; if (c < menor) menor = c;
                if (d > maior) maior = d; if (d < menor) menor = d;
                Console.WriteLine($"Maior valor = {maior}\nMenor valor = {menor}\nA soma do segundo maior valor com o segundo menor valor = {a + b + c + d - (menor + maior)}");
            }
            else Console.WriteLine("Os valores precisam ser diferentes");
            Console.ReadKey();

            
        }
    }
}
