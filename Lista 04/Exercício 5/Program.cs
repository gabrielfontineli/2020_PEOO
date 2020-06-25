using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o dia da semana");
            string dds = Console.ReadLine();
            Console.WriteLine("Informe o horário do filme");
            int h = int.Parse(Console.ReadLine());
            double v = 10;
            switch (dds.ToLower())
            {
                case "segunda":
                case "terça":
                case "quarta": v -= 2; break;
                case "sexta":
                case "sábado": v += 5; break;

            }
            if (h < 17) v -= 2;
            Console.WriteLine($"o valor da entrada é {v:c2}");
            

        }
    }
}
