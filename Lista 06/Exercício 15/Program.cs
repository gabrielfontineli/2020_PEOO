using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string[] ent = Console.ReadLine().Split();
            for (int i = 0; i < ent.Length; i++)
            {
                string t = ent[i];
                Console.Write(t.Length);
            }
            Console.ReadKey();        
        }

    }
}
