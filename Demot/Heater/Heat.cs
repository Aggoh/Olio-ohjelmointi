using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater
{
    class Heat
    {
        public bool IsOn { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Heater data: ");
            Console.WriteLine(" - IsOn : " + IsOn);
            Console.WriteLine(" - Temperature : " + Temperature);
            Console.WriteLine(" - Humidity : " + Humidity);
        }
    }
   
}
