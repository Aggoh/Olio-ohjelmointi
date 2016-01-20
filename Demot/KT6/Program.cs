using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT6
{
        class Program
    {
        static void Main(string[] args)
        {
            Living ownliving = new Living();
            Living rentliving = new Living();
            Console.WriteLine("Press number ´1´ for OWN. Number ´2´ for RENT. Number ´9´ for QUIT");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.Write("Address :"); ownliving.Address = Console.ReadLine();
                    Console.Write("Amount lived :"); ownliving.HowMany = int.Parse(Console.ReadLine());
                    Console.Write("monthly mortgage :"); ownliving.Morgage = int.Parse(Console.ReadLine());

                    ownliving.PrintData1();
                    Console.Write("Cost per year " + (ownliving.Morgage * 12));
                    break;
                case 2:
                    Console.Write("Address :"); rentliving.Address = Console.ReadLine();
                    Console.Write("Amount lived :"); rentliving.HowMany = int.Parse(Console.ReadLine());
                    Console.Write("monthly rent :"); rentliving.RentAm = int.Parse(Console.ReadLine());
                    rentliving.PrintData2();
                    Console.WriteLine("Cost per year :" + (rentliving.RentAm * 12));
                    break;
                default:
                    Console.WriteLine("out of range.");
                    Console.ReadLine();
                    break;
                case 9:
                    Console.WriteLine("Bye.");
                    break;
                

                


            }

        }
    }
}
