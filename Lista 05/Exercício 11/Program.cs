using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Minha terra tem palmeiras";
            int p = s.IndexOf(" ");
            while (p != -1)
            {
                Console.WriteLine(s.Substring(0, p));
                s = s.Substring(p + 1);
                p = s.IndexOf(" ");
            }
            Console.WriteLine(s);
            Console.ReadKey();
            /*
            Minha 
            terra 
            tem 
            palmeiras
             */
        }
    }
}
