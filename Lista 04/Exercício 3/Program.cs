using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salário atual");
            double salario = double.Parse(Console.ReadLine());
            double reajuste = 0;
            if (salario < 500) reajuste = .2 * salario;
            else
                if (salario <= 1000) reajuste = .15 * salario;
            else reajuste = .1 * salario;
            Console.WriteLine($"Seu novo salário é {salario + reajuste:0.00}");

        }
    }
}
