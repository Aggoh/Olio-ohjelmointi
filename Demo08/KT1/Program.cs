using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dice Throw 

            Dice dice = new Dice();
            Console.Write("How many times you want to roll the dice: ");
            int x = int.Parse(Console.ReadLine());
            int[] nums = new int[7];          
            double k = 0;
            double avg;
            for (int y = 0; y < x; y++)
            {
                dice.DiceThrow();
                
                k = (dice.RandNum + k);
                nums[dice.RandNum]++;
            }
            // average calc
            avg = (k / x);

            Console.WriteLine("Average: " + avg);
            Console.WriteLine("\nNumber 1: " + nums[1] + "\nNumber 2: " + nums[2] +
               "\nNumber 3: " + nums[3] + "\nNumber 4: " + nums[4] + "\nNumber 5: " + nums[5] +
               "\nNumber 6: " + nums[6]);

           
        }
    }
}
