using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua massa em kg:");
            int massa = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua altura em metros:");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"Seu IMC é {massa / (Math.Pow(altura, 2)):.00}");
        }
    }
}
