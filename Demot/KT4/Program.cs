using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Name = ("Lada");
            vehicle.Speed = 250;
            vehicle.Tyres = 5;
            vehicle.PrintData();
            Console.WriteLine(vehicle.ToString());
            
           
        }
    }
}
