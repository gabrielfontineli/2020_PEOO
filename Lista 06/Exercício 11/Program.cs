using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string ent = Console.ReadLine();
            int total = 0;
            for (int i = 0; i < ent.Length; i++)
            {
                char c = ent[i];
                if (c >= '1' && c <= '9')
                    total += int.Parse(c.ToString());
            }
            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
