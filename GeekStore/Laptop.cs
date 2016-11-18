using GeekStore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore
{
    public class Laptop: IComputer
    {
        public CPU CPU { get; }
        public GPU GPU { get; }
        public HDD HDD { get; }
        public Monitor Monitor { get; }
        public MotherBoard MotherBoard { get; }
        public RAM RAM { get; }

        public Laptop(CPU cpu, GPU gpu, Monitor monitor, MotherBoard motherBoard, RAM ram)
        {
            CPU = cpu;
            GPU = gpu;
            Monitor = monitor;
            MotherBoard = motherBoard;
            RAM = ram;
        }
    }
}
