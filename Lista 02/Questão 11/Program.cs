using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
            string[] entrada = Console.ReadLine().Split('/');
            string dia = entrada[0]; string mes = entrada[1]; string ano = entrada[2];
            switch (mes)
            {
                case "01": mes = "janeiro"; break;
                case "02": mes = "fevereiro"; break;
                case "03": mes = "março"; break;
                case "04": mes = "abril"; break;
                case "05": mes = "maio"; break;
                case "06": mes = "junho"; break;
                case "07": mes = "julho"; break;
                case "08": mes = "agosto"; break;
                case "09": mes = "setembro"; break;
                case "10": mes = "outubro"; break;
                case "11": mes = "novembro"; break;
                case "12": mes = "dezembro"; break;
            }
            Console.WriteLine($"A data é {dia} de {mes} de {ano}");
            Console.ReadKey();
        }
    }
}
