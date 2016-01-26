using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Vehicle : Tyres
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public List<Tyres> Tyres { get; }
        public Vehicle()
            {
            Tyres = new List<Tyres>();
            }
        public void AddTyre(Tyres tyre)
        {
            Tyres.Add(tyre);
        }
        public override string ToString()
        {
            string sVehilce = "Vechilce Name: " + Name + " Model: " + Model + " Tyres: \n";
            foreach (Tyres tyre in Tyres)
            {
                sVehilce += tyre.ToString() + "\n";
            }
            return sVehilce;

        }

    }
}
