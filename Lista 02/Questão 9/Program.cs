using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o horário no formato hh:mm");
            string[] entrada = Console.ReadLine().Split(':');
            int horas = int.Parse(entrada[0]);
            int minutos = int.Parse(entrada[1]);
            if ((horas > 12) || (minutos > 60)) Console.WriteLine("Hora inválida");
            else
                Console.WriteLine($"Menor angulo entre os ponteiros = {((11*minutos) - (60 * horas))/2} graus");
            Console.ReadKey();
        }
    }
}
