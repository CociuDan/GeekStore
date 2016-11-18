using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Peripherals
{
    public class Headphones: IItems
    {
        public int Impedance { get; }
        public string Manufacturer { get; }
        public string Model { get; }
        public string Type { get; }

        public Headphones(int impedance, string manufacturer, string model, string type)
        {
            Impedance = impedance;
            Manufacturer = manufacturer;
            Model = model;
            Type = type;
        }

        public void ShowItemSpecs()
        {
            Console.WriteLine("Headphones Specs:");
            Console.WriteLine("\t Impedance: " + Impedance);
            Console.WriteLine("\t Manufacturer: " + Manufacturer);
            Console.WriteLine("\t Model: " + Model);
            Console.WriteLine("\t Type: " + Type);
        }
    }
}
