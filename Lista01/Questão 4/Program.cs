using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as notas dos três primeiros bimestres:");
            int primeira = int.Parse(Console.ReadLine());
            int segunda = int.Parse(Console.ReadLine());
            int terceira = int.Parse(Console.ReadLine());
            int soma = (primeira * 2 + segunda * 2 + terceira * 3);
            int aprovado = (600 - soma) / 3;
            Console.WriteLine($"Nota para passar = {aprovado}");
        }
    }
}
