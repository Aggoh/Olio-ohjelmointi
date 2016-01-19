using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT5
{
    class Student
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string School { get; set; }
        public bool ATT { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Student(s) information: ");
            Console.WriteLine(" - First Name: " + FName);
            Console.WriteLine(" - Last Name : " + LName);
            Console.WriteLine(" - Age       : " + Age);
            Console.WriteLine(" - Address   : " + Address);
            Console.WriteLine(" - School    : " + School);
            Console.WriteLine(" - Attending : " + ATT);

        }
        
    }
}
