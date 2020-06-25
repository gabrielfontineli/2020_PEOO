using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro horário");
            string h1 = Console.ReadLine();
            Console.WriteLine("Informe o segundo horário");
            string h2 = Console.ReadLine();
            int min1 = 0, min2 = 0;
            switch (h1)
            {
                case "12:00 AM": min1 = 0; break;
                case "12:00 PM": min1 = 12 * 60; break;
                default:
                    int h = int.Parse(h1.Substring(0, 2));
                    int m = int.Parse(h1.Substring(3, 2));
                    min1 = h * 12 + m;
                    if (h1.Substring(6, 2) == "PM") min1 += (12 * 60);
                    break;
            }
            switch (h2)
            {
                case "12:00 AM": min2 = 0; break;
                case "12:00 PM": min2 = 12 * 60; break;
                default:
                    int h = int.Parse(h2.Substring(0, 2));
                    int m = int.Parse(h2.Substring(3, 2));
                    min2 = h * 12 + m;
                    if (h2.Substring(6, 2) == "PM") min2 += (12 * 60);
                    break;
            }
            if (min1 == min2)
                Console.WriteLine("Os horários são iguais");
            else if (min1 > min2)
                Console.WriteLine("O maior horário é o " + h1);
            else
                Console.WriteLine("O maior horário é o " + h2);
        }
    }
}
