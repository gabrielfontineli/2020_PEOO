using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questão_12_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores inteiros separados por um operador +, -, * ou /");
            string entrada = Console.ReadLine(); 
            char operador;
            if (entrada.Contains("+")) operador = '+';
            else if (entrada.Contains("-")) operador = '-';
            else if (entrada.Contains("*")) operador = '*';
            else if (entrada.Contains("/")) operador = '/';
            return;

            Console.WriteLine(operador);
            

            string[] partes = entrada.Split(operador);
            Console.ReadKey();
        }
    }
}
