using System;

namespace CarEngine
{
    internal class PneumaticStarter : IStarter
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Battery Battery
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public AirCompressor AirCompressor { get; set; }

        public HydraulicPump HydraulicPump
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public IgnitionStatus Start()
        {
            return (AirCompressor.IsLoaded? IgnitionStatus.Success : IgnitionStatus.Failure);
        }
    }
}
