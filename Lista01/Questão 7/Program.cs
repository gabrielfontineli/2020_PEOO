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
            Console.WriteLine("Digite um valor");
            string[] valor = Console.ReadLine().Split('.');
            int reais = int.Parse(valor[0]);
            int centavos = int.Parse(valor[1]);
            Console.WriteLine($"{reais} reais e {centavos} centavos");
        }
    }
}
