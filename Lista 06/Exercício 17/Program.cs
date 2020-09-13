using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_17
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Digite uma frase");
			string[] s = Console.ReadLine().Split();
			for (int k = 0; k < s.Length;k++)
            {
				int vg = 0;
				foreach (char c in s[k])
					switch (c.ToString().ToLower())
						{
						case "a":
						case "e":
						case "i":
						case "o":
						case "u": vg++; break; ;
					}
				for (int i = 0; i < vg; i++)
					Console.Write($"{s[k]} ");
            }
		}
	}
}
