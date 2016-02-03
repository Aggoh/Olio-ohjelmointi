using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT2
{
    class Shopping
    {
        public string Name { get; set; }
        public string Price { get; set; }
       
        public override string ToString()
        {
            return ("Name: " + Name + " Price: " + Price);
        }
        

        
    }
}
