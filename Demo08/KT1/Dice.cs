using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT1
{
    class Dice
    {
        
        Random rand = new Random();
        public int RandNum;

        public void DiceThrow ()
        {            
            
            RandNum = rand.Next(1, 7);
            Console.WriteLine(RandNum);
            
            
            
        }
        

    }
}
