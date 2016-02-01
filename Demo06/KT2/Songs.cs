using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT2
{
    class Songs
    {
        public string SongName { get; set; }
        public string Lenght { get; set; }
        public override string ToString()
        {
            return ("Name: " + SongName + " - " + Lenght);
        }
    }
}
