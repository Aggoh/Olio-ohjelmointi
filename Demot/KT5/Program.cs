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


            {
                Student[] student = new Student[15];
                {
                    for (int i = 0; i < 5;)
                    {
                        Console.Write("Name     : "); student[i].FName = Console.ReadLine();
                        Console.Write("Age      : "); student[i].Age = int.Parse(Console.ReadLine());
                        Console.Write("Address  : "); student[i].Address = Console.ReadLine();
                        Console.Write("School   : "); student[i].School = Console.ReadLine();
                        student[i].ATT = true;
                        i++;

                        {

                            student[i].PrintData();
                        }
                    }
                }

               
            }
        }
        }
    
}
