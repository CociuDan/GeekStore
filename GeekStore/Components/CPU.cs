using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Components
{
    public class CPU : IItems
    {
        private string Architecture { get; }
        private double BaseFrequency { get; }
        private double BoostFrequency { get; }
        private int Cores { get; }
        private string Manufacturer { get; }
        private string Model { get; }
        private int Threads { get; }
        private int TDP { get; }

        public CPU(string architecture, double baseFrequency, double boostFrequency, int cores, string manufacturer, string model, int threads, int tdp)
        {
            Architecture = architecture;
            BaseFrequency = baseFrequency;
            BoostFrequency = boostFrequency;
            Cores = cores;
            Manufacturer = manufacturer;
            Model = model;
            Threads = threads;
            TDP = tdp;
        }

        public void ShowItemSpecs()
        {
            Console.WriteLine("CPU Specs:");
            Console.WriteLine("\t Architecture: " + Architecture);
            Console.WriteLine("\t BaseFrequency: " + BaseFrequency);
            Console.WriteLine("\t BoostFrequency: " + BoostFrequency);
            Console.WriteLine("\t Cores: " + Cores);
            Console.WriteLine("\t Manufacturer: " + Manufacturer);
            Console.WriteLine("\t Model: " + Model);
            Console.WriteLine("\t Threads: " + Threads);
            Console.WriteLine("\t TDP: " + TDP);
        }
    }
}
