using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quatro valores inteiros");
            int w = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int media = (w + x + y + z) / 4;
            Console.WriteLine($"Média = {media}");
            Console.WriteLine("Números menores que a média");
            if (w < media) Console.WriteLine(w);
            if (x < media) Console.WriteLine(x);
            if (y < media) Console.WriteLine(y);
            if (z < media) Console.WriteLine(z);
            Console.WriteLine("Números maiores que a média");
            if (w > media) Console.WriteLine(w);
            if (x > media) Console.WriteLine(x);
            if (y > media) Console.WriteLine(y);
            if (z > media) Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
