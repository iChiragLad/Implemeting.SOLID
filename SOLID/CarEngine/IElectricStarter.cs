using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEngine
{
    internal interface IElectricStarter : IStarter
    {
        Battery Battery { get; set; }
    }
}
