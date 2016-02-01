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
        public CD()
            {
            Songs = new List<Songs>();
            } 
        public void AddSongs (Songs songs)
        {
            Songs.Add(songs);
        }
        public override string ToString()
        {
           string Lsongs = "Name: " + Name + " Artist: " + Artist + "Tracks \n";
           foreach (Songs songs in Songs)
            {
                Lsongs += songs.ToString() + "\n";
            }
            return Lsongs;
           


32         }

    }
}
