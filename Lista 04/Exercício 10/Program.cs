using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercício_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor unitário do produto");
            double v = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade comprada");
            int q = int.Parse(Console.ReadLine());
            double t = 0;
            if (q <= 10)
            {
                t = q * 0.95 * v;
            }
            if (q > 10 && q <= 50)
            {
                t = 10 * 0.95 * v;
                q = q - 10;
                t += (q * 0.9 * v);
            }
            if (q > 50)
            {
                t = 10 * 0.95 * v;
                t += (40 * 0.9 * v);
                q = q - 50;
                t += (q * .8 * v);
            }
            Console.WriteLine($"O total a ser pago é {t:c2}");
        }
    }
}
