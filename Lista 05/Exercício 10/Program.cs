using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Minha terra tem palmeiras";
            string x;
            int c = 0;
            for (int k = 0; k < s.Length; k++)
            {
                x = s.Substring(k, 1);
                if (x == "a" || x == "e" || x == "i") c++;
            }
            Console.WriteLine(c);
            Console.ReadKey();
            
            // 9
        }
    }
}
