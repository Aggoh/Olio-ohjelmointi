using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demot
{
    class Car
    {
        // properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDices { get; set; }

        // constructor
        public Car()
        {
            FuzzyDices = true;
            
        }

        // parametric constructor
        public Car(string model)
        {
            Model = model;
        }

        // method displaus car data

        public void PrintData()
        {
            Console.WriteLine("Car data:");
            Console.WriteLine(" - Model : " + Model);
            Console.WriteLine(" - Color : " + Color);
            Console.WriteLine(" - Engine : " + Engine);
            Console.WriteLine(" - Speed : " + Speed);
            Console.WriteLine(" - FuzzyDices : " + FuzzyDices);

        }
        // method gives more speed
        public void Accelerate(int NewSpeed)
        {
            Speed += NewSpeed;
            
        }
    }
}
