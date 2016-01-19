using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Heater heater = new Heater();
            heater.IsOn = true;
            heater.Temperature = 100;
            heater.Humidity = 85;
            
        }
    }
}
