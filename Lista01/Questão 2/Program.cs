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
            Console.WriteLine("Digite as notas dos dois bimestres da disciplina:");
            int primeiraNota = int.Parse(Console.ReadLine());
            int segundaNota = int.Parse(Console.ReadLine());

            Console.WriteLine($"Media Parcial = {((primeiraNota * 2 + segundaNota * 3) / 5)}");
        }
    }
}
