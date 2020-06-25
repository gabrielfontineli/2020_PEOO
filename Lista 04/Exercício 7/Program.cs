using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a data do aniversário");
            string[] data = Console.ReadLine().Split('/');
            int m = int.Parse(data[1]); int d = int.Parse(data[0]);
            int max = 31;
                switch (m)
                {
                case 2: max = 29; break;
                case 4:
                case 6:
                case 9:
                case 11: max = 30; break;
                }
            if (d >= 1 && d <= max && m >= 1 && m <= 12)
                Console.WriteLine("A data informada é válida");
            else
                Console.WriteLine("A data informada não é válida");
            

        }
    }
}
