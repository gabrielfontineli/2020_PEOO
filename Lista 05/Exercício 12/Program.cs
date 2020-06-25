using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Minha terra tem palmeiras";
            int k = s.Length - 1;
            while (k > 0)
            {
                if (s[k] == ' ')
                {
                    Console.WriteLine(s.Substring(k + 1));
                    s = s.Substring(0, k);
                }
                k--;
            }
            Console.WriteLine(s);
            Console.ReadKey();
            /*
            palmeiras
            tem
            terra
            Minha
             */
        }
    }
}
