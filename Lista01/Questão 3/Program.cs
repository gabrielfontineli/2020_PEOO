using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio de um círculo:");
            float raio = float.Parse(Console.ReadLine());
            double circunferencia = (Math.PI * 2 * raio);
            double area = (Math.PI * Math.Pow(raio, 2));
            Console.WriteLine($"Circunferência = {circunferencia:.00}\nÁrea = {area:.00} ");
        }
    }
}
