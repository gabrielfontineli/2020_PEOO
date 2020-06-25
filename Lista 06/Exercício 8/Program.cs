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
            Console.WriteLine("Digite uma frase:");
            string[] s = Console.ReadLine().Split();
            for (int i = 0; i < s.Length; i++)
            {
                string p = s[i];
                char c = p[p.Length - 1];
                Console.Write(c);
            }

        }
    }
}
