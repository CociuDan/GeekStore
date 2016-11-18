using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Peripherals
{
    public class Keyboard : IItems
    {
        private string Manufacturer { get; }
        private string Model { get; }
        private string Type { get; }

        public Keyboard(string manufacturer, string model, string type)
        {
            Manufacturer = manufacturer;
            Model = model;
            Type = type;
        }

        public void ShowItemSpecs()
        {
            Console.WriteLine("Keyboard Specs:");
            Console.WriteLine("\t Manufacturer: " + Manufacturer);
            Console.WriteLine("\t Model: " + Model);
            Console.WriteLine("\t Type: " + Type);
        }
    }
}
