using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Console.Write("First Name: "); student1.FName = Console.ReadLine();
            Console.Write("Last Name: "); student1.LName = Console.ReadLine();
            Console.Write("Age: "); student1.Age = int.Parse(Console.ReadLine());
            Console.Write("Address: "); student1.Address = Console.ReadLine();
            Console.Write("School: "); student1.School = Console.ReadLine();
            student1.ATT = true;
            student1.PrintData();
        

            Student student2 = new Student();
            student2.FName = "Marja";
            student2.LName = "Kulma";
            student2.Age = 21;
            student2.Address = "Orvokinkatu 9 B 14";
            student2.School = "Jyväskylä, University";
            student2.ATT = true;
            student2.PrintData();



        }
    }
}
