using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os coeficientes a, b, e c de uma equação do II grau");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double formulap = (-b + Math.Sqrt(Math.Pow(b,2) - 4 * a * c))/(2*a);
            double formulan = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

            if ((formulap % 1 == 0) && (formulan % 1 == 0)) Console.WriteLine($"As raízes são {formulap} e {formulan}");
            else Console.WriteLine("impossível calcular");
            Console.ReadKey();




        }
    }
}
