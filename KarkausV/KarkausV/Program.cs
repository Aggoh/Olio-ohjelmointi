﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarkausV
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuosi;
            Console.Write("Anna vuosiluku: ");
            vuosi = int.Parse(Console.ReadLine());

            if (vuosi % 4 == 0 && vuosi % 100 != 0 || vuosi % 400 == 0)
                
            {
                Console.Write("Karkausvuosi!");
            }
            else
            {
                Console.WriteLine("Ei. Ole. ");
            }

           

        }
    }
}
