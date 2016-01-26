using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4
{
    class Computer
    {
        public string Name { get; set; }
        public List<Components> Components { get; }
        public Computer()
        {
            Components = new List<Components>();
        }
        public void Addcompo(Components components)
        {
            Components.Add(components);
        }
        public override string ToString()
        {
            string Comps = "Vechilce Name: " + Name + " Model: ";
            foreach (Components components in Components)
            {
                Comps += Components.ToString() + "\n";
            }
            return Comps;

        }
    }
}
