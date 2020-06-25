using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um horário");
            string ent = Console.ReadLine();
            int h = int.Parse(ent.Substring(0, 2));
            int m = int.Parse(ent.Substring(3, 2));
            if (h >= 0 && h <= 23 && m >= 0 && m <= 59)
                Console.WriteLine("O horário informado é válido");
            else
                Console.WriteLine("O horário informado não é válido");




        }
    }
}
