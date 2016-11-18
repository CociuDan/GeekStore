using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Peripherals
{
    public class Mouse : IItems
    {
        private short DPI { get; }
        private string Manufacturer { get; }
        private string Model { get; }
        private string Type { get; }

        public Mouse(short dpi, string manufacturer, string model, string type)
        {
            DPI = dpi;
            Manufacturer = manufacturer;
            Model = model;
            Type = type;
        }

        public void ShowItemSpecs()
        {
            Console.WriteLine("Mouse Specs:");
            Console.WriteLine("\t DPI: " + DPI);
            Console.WriteLine("\t Manufacturer: " + Manufacturer);
            Console.WriteLine("\t Model: " + Model);
            Console.WriteLine("\t Type: " + Type);
        }
    }
}
