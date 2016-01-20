using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Maija ";
            person.LastName = "Maijakas ";
            person.Address = "Osoitekatu 1";
            person.Age = 19;
            person.PhoneNumber = "0400-169112";
            Console.WriteLine(person.ToString());

            Teacher teacher = new Teacher("Jussi", "Konsoli", "D456");
            teacher.Address = "Piippukatu 1";
            teacher.Age = 40;
            teacher.PhoneNumber = "010-339 551";
            Console.WriteLine(teacher.ToString());

            Student student = new Student("Kaarlo", "Liimatainen", "K4454");
            student.Address = "Kypärätie 24 B";
            student.Age = 25;
            student.PhoneNumber = "010299044";
            Console.WriteLine(student.ToString());
                        
            
            
                              
        }
        
    }
}
