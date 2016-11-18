using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Components
{
    public class HDD : IItems
    {
        private int Capacity { get; }
        private string Manufacturer { get; }
        private string Model { get; }
        private int ReadSpeed { get; }
        private int RPM { get; }
        private string Type { get; }
        private int WriteSpeed { get; }

        public HDD(int capacity, string manufacturer, string model, int readSpeed, int rpm, string type, int writeSpeed)
        {
            Capacity = capacity;
            Manufacturer = manufacturer;
            Model = model;
            ReadSpeed = readSpeed;
            RPM = rpm;
            Type = type;
            WriteSpeed = writeSpeed;
        }

        public void ShowItemSpecs()
        {
            Console.WriteLine("HDD Specs:");
            Console.WriteLine("\t Capacity: " + Capacity);
            Console.WriteLine("\t Manufacturer: " + Manufacturer);
            Console.WriteLine("\t Model: " + Model);
            Console.WriteLine("\t ReadSpeed: " + ReadSpeed);
            Console.WriteLine("\t RPM: " + RPM);
            Console.WriteLine("\t Type: " + Type);
            Console.WriteLine("\t WriteSpeed: " + WriteSpeed);
        }
    }
}
