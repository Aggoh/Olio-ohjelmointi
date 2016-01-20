using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars car = new Cars();
            car.Speed = 300;
            Console.WriteLine("Car speed is " + car.Speed);

            Console.ReadLine(); 
        }
    }
}
