using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT6
{
    class Living
    {
        public string Address { get; set; }
        public bool Own { get; set; }
        public bool Rent { get; set; }
        public int RentAm { get; set; }
        public int Morgage { get; set; }
        public int HowMany { get; set; }

        public void PrintData1()
        {
            Own = true;
            Console.WriteLine("Data: Owned : ");
            Console.WriteLine("Own : " + Own);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Mortgage : " + Morgage);
            Console.WriteLine("You've spent: " + (HowMany * Morgage));
         }
        public void PrintData2()
        {
            Rent = true;
            Console.WriteLine("Data: Rented : ");
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Rent : " + Rent);
            Console.WriteLine("Rent Amount : " + RentAm);
            Console.WriteLine("You've spent: " + (HowMany * RentAm));
        }
    }
}
