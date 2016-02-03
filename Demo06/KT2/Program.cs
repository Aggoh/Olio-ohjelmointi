using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT2
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD();
            cd.Artist = "Pain Of Salvation";
            cd.Name = "Remedy Lane";

            List<Songs> songs = new List<Songs>();
            songs.Add(new Songs { SongName = "Of Two Beginnings", Lenght = "2:24" });
            songs.Add(new Songs { SongName = "Ending Theme", Lenght = "4:59" });
            songs.Add(new Songs { SongName = "Fandango", Lenght = "5:51" });
            songs.Add(new Songs { SongName = "Trace Of Blood", Lenght = "8:17" });
            songs.Add(new Songs { SongName = "This Heart Of Mine", Lenght = "4:01" });
            songs.Add(new Songs { SongName = "Undertow", Lenght = "4:47" });
            songs.Add(new Songs { SongName = "Rope Ends", Lenght = "7:02" });
            songs.Add(new Songs { SongName = "Dryad Of The Woods", Lenght = "4:56" });
            songs.Add(new Songs { SongName = "Remedy Lane", Lenght = "2:15" });
            songs.Add(new Songs { SongName = "Waking Every God", Lenght = "5:19" });
            songs.Add(new Songs { SongName = "Second Love", Lenght = "4:21" });
            songs.Add(new Songs { SongName = "Beyond The Pale", Lenght = "9:56" });

            Console.WriteLine(cd.ToString());
            foreach (Songs track in songs)
            {
                Console.WriteLine(track.ToString());
            }



        }
    }
}
