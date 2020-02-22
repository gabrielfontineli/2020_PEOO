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
            Console.WriteLine("Digite o primeiro horário no formato hh:mm");
            string[] prim = Console.ReadLine().Split(':');
            Console.WriteLine("Digite o segundo horário no formato hh:mm");
            string[] seg = Console.ReadLine().Split(':');

            int min = int.Parse(prim[1]) + int.Parse(seg[1]);
            int hora = (min / 60) + int.Parse(prim[0]) + int.Parse(seg[0]);
            if (min >= 60) min %= 60;

            Console.WriteLine($"Total de horas = {hora:00}:{min}");
            Console.ReadKey();
        }
    }
}
