using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Cars
    {
        //max soeed
        private readonly int MaxSpeed = 200;
        //member field
        private int speed;
        // property
        public int Speed
        {
          get
            {
                return speed;
            }
          set
            {
                if (value <= MaxSpeed) speed = value;
                else
                {
                    if (value > MaxSpeed) Console.WriteLine("Too much speed - set to max!");
                    speed = MaxSpeed;
                }
            }
        }


    }
}
