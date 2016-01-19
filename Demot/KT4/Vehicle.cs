using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public override string ToString()
        {
            return "Name " + Name + "Speed" + Speed + "Tyres" + Tyres;
        }

        public void PrintData()
        { 
            Console.WriteLine("Vehicle Data: ");
            Console.WriteLine(" - Name : " +Name);
            Console.WriteLine(" - Speed : " +Speed);
            Console.WriteLine(" - Tyres : " +Tyres);
        }

    }
}
