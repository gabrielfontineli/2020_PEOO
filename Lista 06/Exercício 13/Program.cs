using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string ent = Console.ReadLine();
            for (int i = ent.Length - 1; i >= 0; i--)
                Console.Write(ent[i]);
            Console.ReadKey();

        }
    }
}
