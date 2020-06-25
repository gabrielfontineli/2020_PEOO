using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string ent = Console.ReadLine();
            int total = 1;
            for (int i = 1; i < ent.Length; i++)
            {
                char c = ent[i];
                if (c == ' ') total ++;
            }
            Console.WriteLine(total);
            Console.ReadKey();

        }
    }
}
