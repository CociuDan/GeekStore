using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Peripherals
{
    public class Speakers : IItems
    {
        private string Manufacturer { get; }
        private string Model { get; }
        private double SystemType { get; }
        private int Watts { get; }

        public Speakers(string manufacturer, string model, double systemType, int watts)
        {
            Manufacturer = manufacturer;
            Model = model;
            SystemType = systemType;
            Watts = watts;
        }

        public void ShowItemSpecs()
        {
            Console.WriteLine("Speakers Specs:");
            Console.WriteLine("\t Manufacturer: " + Manufacturer);
            Console.WriteLine("\t Model: " + Model);
            Console.WriteLine("\t SystemType: " + SystemType);
            Console.WriteLine("\t Watts: " + Watts);
        }
    }
}
