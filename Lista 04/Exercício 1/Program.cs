using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            string[] nome = Console.ReadLine().Split(' ');
            Console.WriteLine($"Resultado\n{nome[1]}, {nome[0]}");
        }
    }
}
