using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus9
{
    class Program
    {
        static void Main(string[] args)
        {

            int luku;
            int sum = 0;
            do
            {
                Console.Write("Anna lukuja : ");
                luku = int.Parse(Console.ReadLine());
                sum = (luku + sum);
      
            } while (luku != 0);

            Console.Write("Syöttämiesi numeroiden summa on: ");
            Console.WriteLine(sum);
                
            





        }
    }
}
