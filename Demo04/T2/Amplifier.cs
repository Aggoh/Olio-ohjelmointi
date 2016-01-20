using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Amplifier
    {
        private int MaxVolume = 100;
        private int LowVolume = 0;
        private int volume = 1;

        public int Volume
        {
            get
            { return volume; }  
                      
            set
            {
                if (value <= MaxVolume && value >= LowVolume)
                volume = value; 
                else {
                    Console.WriteLine("Out of range..");
                }
            }
        }

    }
}
