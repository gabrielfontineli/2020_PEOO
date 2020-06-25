using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome da primeira pessoa");
            string nome1 = Console.ReadLine();
            Console.WriteLine("Informe a data de nascimento da primeira pessoa");
            string[] data1 = Console.ReadLine().Split('/');
            Console.WriteLine("Informe o nome da segunda pessoa");
            string nome2 = Console.ReadLine();
            Console.WriteLine("Informe a data de nascimento da segunda pessoa");
            string[] data2 = Console.ReadLine().Split('/');
            int ano1, ano2, mes1, mes2, dia1, dia2;
            ano1 = int.Parse(data1[2]); ano2 = int.Parse(data2[2]);
            mes1 = int.Parse(data1[1]); mes2 = int.Parse(data2[1]);
            dia1 = int.Parse(data1[0]); dia2 = int.Parse(data2[0]);
            if (data1 == data2) Console.WriteLine($"{nome1} e {nome2} têm a mesma idade");
            else {
                if ((ano1 < ano2) || ano1 == ano2 && mes1 < mes2 || ano1 == ano2 && mes1 == mes2 && dia1 < dia2) Console.WriteLine($"{nome1} é mais velho(a) que {nome2}");
                else Console.WriteLine($"{nome2} é mais velho(a) que {nome1}");

            }


        }
    }
}
