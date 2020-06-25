using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase");
            string ent = Console.ReadLine();
            int p = ent.IndexOf(' ');
            while (p != -1)
            {
                Console.WriteLine(ent);
                ent = ent.Substring(p + 1);
                p = ent.IndexOf(' ');
            }
            Console.WriteLine(ent);
            Console.ReadKey();

        }
    }
}
