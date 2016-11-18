using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Components
{
    public class Monitor : IItems
    {
        private int Frequency { get; }
        private string Manufacturer { get; }
        private string Model { get; }
        private string Resolution { get; }
        private double ScreenSize { get; }

        public Monitor(int frequency, string manufacturer, string model, string resolution, double screenSize)
        {
            Frequency = frequency;
            Manufacturer = manufacturer;
            Model = model;
            Resolution = resolution;
            ScreenSize = screenSize;
        }

        public void ShowItemSpecs()
        {
            Console.WriteLine("Monitor Specs:");
            Console.WriteLine("\t Frequency: " + Frequency);
            Console.WriteLine("\t Manufacturer: " + Manufacturer);
            Console.WriteLine("\t Model: " + Model);
            Console.WriteLine("\t Resolution: " + Resolution);
            Console.WriteLine("\t ScreenSize: " + ScreenSize);
        }
    }
}
