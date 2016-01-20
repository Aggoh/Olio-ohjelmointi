using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You're in the elevator!");
            Elevator elevator = new Elevator();

            do
            {

                Console.Write("You are at floor " + elevator.Floor + " Press (1-5)");
                elevator.Floor = int.Parse(Console.ReadLine());

            } while (true); 
              
        }
    }
}
