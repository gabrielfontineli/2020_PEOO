﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            for (int k = 1; k <= 10; k++)
            {
                Console.WriteLine(k);
                s += k;
            }
            Console.WriteLine(s);
            Console.ReadKey();
            
            /* 
            1 
            1
            2
            2
            3
            3
            4
            4 
            5
            5
            6
            6
            7
            7
            8
            8
            9
            9
            10
            10
            */
        }
    }
}
