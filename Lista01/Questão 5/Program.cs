using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua data de nascimento:");
            string[] nascimento = Console.ReadLine().Split('/');
            int ano = int.Parse(nascimento[2]);
            Console.WriteLine($"Em 31/12/2020 você terá {2020 - ano} anos");
        }
    }
}
