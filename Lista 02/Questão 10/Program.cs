using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
            string[] entrada = Console.ReadLine().Split('/');
            int d = int.Parse(entrada[0]);
            int m = int.Parse(entrada[1]);
            int a = int.Parse(entrada[2]);
            int max = 31;
            switch(m) {
                case 2:
                    if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0) max = 29;
                    else max = 28; break;
                case 4:
                case 6:
                case 9:
                case 11: max = 30; break;
            }
            if (d >= 1 && d <= max && m >= 1 && m <= 12 && a >= 1900 && a <= 2100)
                Console.WriteLine("Data válida");
            else
                Console.WriteLine("Data inválida");
            Console.ReadKey();

        }

        }
    }
