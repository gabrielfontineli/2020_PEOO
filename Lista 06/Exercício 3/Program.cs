using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 1;
            for (int x = 1; x <= 10; x++, aux = -aux)
                Console.Write($"{x * aux} ");
            Console.WriteLine();
            Console.ReadKey();


        }
    }
}
