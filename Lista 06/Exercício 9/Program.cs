using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string ent = Console.ReadLine();
            for (int ind = 1; ind <= ent.Length; ind++) 
                Console.WriteLine($" {ind}- {ent}" );
            Console.ReadKey();
        }
    }
}
