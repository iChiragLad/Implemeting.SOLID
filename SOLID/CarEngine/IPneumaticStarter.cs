using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEngine
{
    interface IPneumaticStarter : IStarter
    {
        AirCompressor AirCompressor { get; set; }
    }
}
