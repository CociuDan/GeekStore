using GeekStore.Components;
using GeekStore.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore
{
    public class DesktopPC : IComputer
    {
        public Case Case { get; private set; }
        public Cooler Cooler { get; private set; }
        public CPU CPU { get; private set; }
        public GPU GPU { get; private set; }
        public HDD HDD { get; private set; }
        public Keyboard Keyboard { get; private set; }
        public Monitor Monitor { get; private set; }
        public MotherBoard MotherBoard { get; private set; }
        public Mouse Mouse { get; private set; }
        public PSU PSU { get; private set; }
        public RAM RAM { get; private set; }

        public DesktopPC(Case pcCase, Cooler cooler, CPU cpu, GPU gpu, HDD hdd, Keyboard keyboard, Monitor monitor, MotherBoard motherBoard, Mouse mouse, PSU psu, RAM ram)
        {
            Case = pcCase;
            Cooler = cooler;
            CPU = cpu;
            GPU = gpu;
            HDD = hdd;
            Keyboard = keyboard;
            Monitor = monitor;
            MotherBoard = motherBoard;
            Mouse = mouse;
            PSU = psu;
            RAM = ram;
        }

        public void ChangeComponentOrPeripherial(IItems item)
        {

        }
    }
}
