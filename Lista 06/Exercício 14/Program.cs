using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string[] ent = Console.ReadLine().Split(' ');
            for (int e = 0; e < ent.Length; e++)
            {
                string t = ent[e];
                for (int i = t.Length - 1; i >= 0; i--)
                    Console.Write(t[i]);
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
