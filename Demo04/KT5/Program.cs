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
            Radio radio = new Radio();
            int numb;
            while (true)
            {
                Console.WriteLine("Adjust Radio: ");
                Console.WriteLine(" - Press 1 to ON/OFF");
                Console.WriteLine(" - Press 2 to adjust VOLUME");
                Console.WriteLine(" - Press 3 Adjust FREQUENCY");
                Console.WriteLine(" - Press 4 to check STATUS");


                numb = int.Parse(Console.ReadLine());
                switch (numb)
                {
                    default: Console.WriteLine("Read the instructions...");
                    break;

                    case 1:
                        if  (radio.OnOFF != false)
                        { 
                            radio.OnOFF = false;
                            Console.WriteLine("Radio is OFF");
                        }
                        else
                           
                        { 
                        radio.OnOFF = true;
                            Console.WriteLine("Radio is ON");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Volume is " + radio.Volume + " 0-9");
                        radio.Volume = int.Parse(Console.ReadLine());
                        Console.WriteLine("Volume set: " + radio.Volume);
                        break;
                    case 3:
                        Console.WriteLine("Frequency is " + radio.Freq + " 2000.0 - 26000.0 ");
                        radio.Freq = int.Parse(Console.ReadLine());
                        Console.WriteLine("Frequency set: " + radio.Freq);
                        break;
                    case 4:
                        radio.PrintData();
                        break;


                    







                }
                
            }
        }
    }
}
