using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Components
{
    public class Cooler : IItems
    {
        private string Manufacturer { get; }
        private int MaxTDP { get; }
        private string Model { get; }
        private string Socket { get; }


        public Cooler(string manufacturer, int maxTDP, string model, string socket)
        {
            Manufacturer = manufacturer;
            Model = model;
            Socket = socket;
            MaxTDP = maxTDP;
        }

        public void ShowItemSpecs()
        {
            Console.WriteLine("Cooler Specs:");
            Console.WriteLine("\t Manufacturer: " + Manufacturer);
            Console.WriteLine("\t MaxTDP: " + MaxTDP);
            Console.WriteLine("\t Model: " + Model);
            Console.WriteLine("\t Socket: " + Socket);
        }
    }
}
