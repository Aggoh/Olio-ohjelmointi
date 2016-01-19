using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApp
{
    class Heater
    {
        public bool IsOn { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }
    }

    public void DataPrint()
    {

        Console.WriteLine("Heater data :");
        Console.WriteLine("- IsOn :");
        Console.WriteLine("- Temperature :");
        Console.WriteLine("Heater data :");
    }

    // method returns heater data
    public overdrive string ToString()
    {
        return "Temperature : " + Temperature + "humidity" + Humidity
    }
}
