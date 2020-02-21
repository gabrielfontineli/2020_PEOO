using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Há quantos anos você fuma?");
            int anos = int.Parse(Console.ReadLine());
            int dias = anos * 365;

            Console.WriteLine("Quantos cigarros por dia?");
            int cigarros = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o preço da carteira de cigarros?");
            double preço = double.Parse(Console.ReadLine());



            Console.WriteLine($"Total gasto = R$ {dias * (cigarros * preço / 2)}");
        }
    }
}
