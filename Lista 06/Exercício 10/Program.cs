using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string ent = Console.ReadLine();
            for (int i = 0; i < ent.Length; i++)
            {
                char c = ent[0];
                string r = ent.Substring(1);
                ent = r + c;
                Console.WriteLine(ent);
            }
            Console.ReadKey();
        }
    }
}
