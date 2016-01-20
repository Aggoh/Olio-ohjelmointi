using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amplifier = new Amplifier();

            while (true)
            {
                Console.WriteLine("Ampplifiers volume is: " + amplifier.Volume);
                amplifier.Volume = int.Parse(Console.ReadLine());

            }
        }
    }
}
