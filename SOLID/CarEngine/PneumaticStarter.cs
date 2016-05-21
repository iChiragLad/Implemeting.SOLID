using System;

namespace CarEngine
{
    internal class PneumaticStarter : IPneumaticStarter
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public AirCompressor AirCompressor { get; set; }

        public IgnitionStatus Start()
        {
            return (AirCompressor.IsLoaded ? IgnitionStatus.Success : IgnitionStatus.Failure);
        }
    }
}
