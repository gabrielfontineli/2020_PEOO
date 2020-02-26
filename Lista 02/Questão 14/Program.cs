using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três valores:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            bool triangulo;

            if ((Math.Abs(b - c) < a) && (a < (b + c))) triangulo = true; else triangulo = false;
            if (triangulo == false) Console.WriteLine("Esses valores não formam um triângulo");

            if ((triangulo == true) && (a == b) && (b == c)) Console.WriteLine("Esses valores formam um triângulo equilátero");
            else if ((triangulo == true) && (a != b) && (b != c)) Console.WriteLine("Esses valores formam um triângulo escaleno");
            else if ((triangulo == true) && (a == b) || (b == c) || (a == c)) Console.WriteLine("Esses valores formam um triangulo isósceles");


            Console.ReadKey();


        }
    }
}
