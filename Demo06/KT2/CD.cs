using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT2
{
    class CD : Songs
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public List<Songs> Songs { get; }
      
        public override string ToString()
        {
            return ("Name: " + Artist + "\n" + "Album: " + Name + "\n" + "Tracks:");
        }

    }
}
