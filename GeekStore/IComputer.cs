using GeekStore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore
{
    public interface IComputer
    {
        CPU CPU { get; }
        GPU GPU { get; }
        HDD HDD { get; }
        Monitor Monitor { get; }
        MotherBoard MotherBoard { get; }
        RAM RAM { get; }
    }
}
