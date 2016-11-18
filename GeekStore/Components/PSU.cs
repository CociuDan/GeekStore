using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Components
{
    public class PSU : IItems
    {
        private string Manufacturer { get; }
        private string Model { get; }
        private int Power { get; }

        public PSU(string manufacturer, string model, int power)
        {
            Manufacturer = manufacturer;
            Model = model;
            Power = power;
        }

        public void ShowItemSpecs()
        {
            Console.WriteLine("PSU Specs:");
            Console.WriteLine("\t Manufacturer: " + Manufacturer);
            Console.WriteLine("\t Model: " + Model);
            Console.WriteLine("\t Power: " + Power);
        }
    }
}
