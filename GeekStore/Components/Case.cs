using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Components
{
    public class Case : IItems
    {
        private string FormFactor { get; }
        private string Manufacturer { get; }
        private string Model { get; }

        public Case(string formFactor, string manufacturer, string model)
        {
            FormFactor = formFactor;
            Manufacturer = manufacturer;
            Model = model;
        }

        public void ShowItemSpecs()
        {
            Console.WriteLine("Case Specs:");
            Console.WriteLine("\t Form Factor: " + FormFactor);
            Console.WriteLine("\t Manufacturer: " + Manufacturer);
            Console.WriteLine("\t Model: " + Model);
        }
    }
}
