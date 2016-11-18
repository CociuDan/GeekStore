using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Components
{
    public class GPU : IItems
    {
        private string Architecture { get; }
        private int BandWidth { get; }
        private string Manufacturer { get; }
        private string Model { get; }
        private int VRAM { get; }

        public GPU(string architecture, int bandWidth, string manufacturer, string model, int vram)
        {
            Architecture = architecture;
            BandWidth = bandWidth;
            Manufacturer = manufacturer;
            Model = model;
            VRAM = vram;
        }

        public void ShowItemSpecs()
        {
            Console.WriteLine("GPU Specs:");
            Console.WriteLine("\t Architecture: " + Architecture);
            Console.WriteLine("\t BandWidth: " + BandWidth);
            Console.WriteLine("\t Manufacturer: " + Manufacturer);
            Console.WriteLine("\t Model: " + Model);
            Console.WriteLine("\t VRAM: " + VRAM);
        }
    }
}
