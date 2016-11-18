using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Components
{
    public class RAM : IItems
    {
        private int Capacity { get; }
        private int Frequency { get; }
        private string Generation { get; }
        private string Manufacturer { get; }
        private string Model { get; }

        public RAM(int capacity, int frequency, string generation, string manufacturer, string model)
        {
            Capacity = capacity;
            Frequency = frequency;
            Generation = generation;
            Manufacturer = manufacturer;
            Model = model;
        }

        public void ShowItemSpecs()
        {
            Console.WriteLine("RAM Specs:");
            Console.WriteLine("\t Capacity: " + Capacity);
            Console.WriteLine("\t Frequency: " + Frequency);
            Console.WriteLine("\t Generation: " + Generation);
            Console.WriteLine("\t Manufacturer: " + Manufacturer);
            Console.WriteLine("\t Model: " + Model);
        }
    }
}
