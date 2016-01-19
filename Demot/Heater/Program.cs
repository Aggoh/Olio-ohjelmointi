using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater
{
    class Program
    {
        static void Main(string[] args)
        {
            Heat heat = new Heat();
            heat.IsOn = true;
            heat.Temperature = 100;
            heat.Humidity = 85;
            heat.PrintData();

        }
    }
}
