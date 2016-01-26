using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4
{
    class Components
    {
        public string Ram { get; set; }
        public string Cpu { get; set; }
        public override string ToString()
        {
            return ("Memory: " + Ram + " Cpu: " + Cpu);
        }
    }
}
