using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número do mês");
            string mes = Console.ReadLine();
            string tri = "0";
            switch (mes) {
                case "1": mes = "janeiro"; tri = "primeiro"; break;
                case "2": mes = "fevereiro"; tri = "primeiro"; break;
                case "3": mes = "março"; tri = "primeiro"; break;
                case "4": mes = "abril"; tri = "segundo"; break;
                case "5": mes = "maio"; tri = "segundo"; break;
                case "6": mes = "junho"; tri = "segundo"; break;
                case "7": mes = "julho"; tri = "terceiro"; break;
                case "8": mes = "agosto"; tri = "terceiro"; break;
                case "9": mes = "setembro"; tri = "terceiro"; break;
                case "10": mes = "outubro"; tri = "quarto"; break;
                case "11": mes = "novembro"; tri = "quarto"; break;
                case "12": mes = "dezembro"; tri = "quarto"; break;
            }
            Console.WriteLine($"o mês de {mes} é do {tri} trimestre do ano");
            Console.ReadKey();



        }
    }
}
