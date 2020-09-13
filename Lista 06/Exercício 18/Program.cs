using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma sequência de números separados por vírgula:");
            string[] s = Console.ReadLine().Split(',');
            int soma = 0;
            for (int k = 0; k < s.Length; k++)
            {
                string v = s[k];
                soma += int.Parse(v);
            }
            Console.WriteLine(soma);
            

        }
    }
}
