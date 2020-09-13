using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_16
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Digite uma frase");
			string s = Console.ReadLine();
			int a = 0, e = 0, i = 0, o = 0, u = 0;
			s = s.ToLower();
			for (int k = 0; k < s.Length; k++)
				switch (s[k])
				{
					case 'a': a++; break;
					case 'e': e++; break;
					case 'i': i++; break;
					case 'o': o++; break;

				}
			Console.WriteLine($"A - {a}");
			Console.WriteLine($"E - {e}");
			Console.WriteLine($"I - {i}");
			Console.WriteLine($"O - {o}");
			Console.WriteLine($"U - {u}");
			Console.ReadKey();


		}
	}
}
