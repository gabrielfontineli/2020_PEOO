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
            Console.WriteLine("Digite a base e a altura do retângulo");
            int b = int.Parse(Console.ReadLine());
            int altura = int.Parse(Console.ReadLine());
            Console.WriteLine($"Área = {b * altura} - Perímetro = {b * 2 + altura * 2} - Diagonal = {Math.Sqrt(Math.Pow(b, 2) + Math.Pow(altura, 2))}");
        }
    }
}
