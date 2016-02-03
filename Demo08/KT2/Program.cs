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
            
            List<Shopping> shop = new List<Shopping>();
            shop.Add(new Shopping {Name = "Kit-Kat ", Price = "2.15" });
            shop.Add(new Shopping {Name = "Bananananana-na ", Price = "6,89" });
            shop.Add(new Shopping {Name = "Mudcake ", Price = "95 " });

            Console.WriteLine("Shopping List:");
            foreach (Shopping items in shop)
            {
                Console.WriteLine(items.ToString());
            }
        }
        
    }
}
