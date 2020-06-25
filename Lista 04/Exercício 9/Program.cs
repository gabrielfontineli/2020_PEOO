using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe quatro valores inteiros diferentes");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int x;
            if (a > b) { x = a; a = b; b = x; } // tirar dúvida
            if (a > c) { x = a; a = c; c = x; }
            if (a > d) { x = a; a = d; d = x; }
            if (b > c) { x = b; b = c; c = x; }
            if (b > d) { x = b; b = d; d = x; }
            if (c > d) { x = c; c = d; d = x; }

           Console.WriteLine($"A soma dos dois menores valores é {a + b}");

            

        }
    }
}
