using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT5
{
    public struct Student
    {
        public string FName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string School { get; set; }
        public bool ATT { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Student(s) information: ");
            Console.WriteLine(" - Name      : " + FName);
            Console.WriteLine(" - Age       : " + Age);
            Console.WriteLine(" - Address   : " + Address);
            Console.WriteLine(" - School    : " + School);
            Console.WriteLine(" - Attending : " + ATT);

        }
        
    }
}
