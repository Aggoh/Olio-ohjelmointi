using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Elevator
    {
        private int MaxFloor = 5;
        private int LowFloor = 1;
        private int floor = 1;

        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value <= MaxFloor && value >= LowFloor) floor = value;
                else
                {
                    Console.WriteLine("This floor does not exist!");
                    value = floor;
                }
            }
        }
    }
}