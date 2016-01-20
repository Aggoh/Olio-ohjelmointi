using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT5
{
    class Radio
    {
        public bool OnOFF { get; set;}

        private int MaxVolume = 9;
        private int LowVolume = 0;
        private int volume;
        public int Volume
        {
            get { return volume; }
            set { if (value <= MaxVolume && value >= LowVolume)
            volume = value;}
        }

        private int MaxFre = 26000;
        private int LowFre = 2000;
        private int freq;
        public int Freq
        {
            get { return freq; }
            set
            {
                if (value <= MaxFre && value >= LowFre)
                    freq = value;
            }
        }
            public void PrintData()
        {
            Console.WriteLine("Radio Status: ");
            Console.WriteLine("ON/OFF: " + OnOFF);
            Console.WriteLine("Volume: " +Volume);
            Console.WriteLine("Frequency: " +Freq);

        }

        }

    }

