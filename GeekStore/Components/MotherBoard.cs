using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Components
{
    public class MotherBoard : IItems
    {
        private string ChipSet { get; }
        private string Manufacturer { get; }
        private string Model { get; }
        private string RAMGeneration { get; }
        private string Socket { get; }

        public MotherBoard(string chipSet, string manufacturer, string model, string ramGeneration, string socket)
        {
            ChipSet = chipSet;
            Manufacturer = manufacturer;
            Model = model;
            RAMGeneration = ramGeneration;
            Socket = socket;
        }

        public void ShowItemSpecs()
        {
            Console.WriteLine("MotherBoard Specs:");
            Console.WriteLine("\t ChipSet: " + ChipSet);
            Console.WriteLine("\t Manufacturer: " + Manufacturer);
            Console.WriteLine("\t Model: " + Model);
            Console.WriteLine("\t RAMGeneration: " + RAMGeneration);
            Console.WriteLine("\t Socket: " + Socket);
        }
    }
}
