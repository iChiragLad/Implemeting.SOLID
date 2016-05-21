using System;

namespace CarEngine
{
    internal class ElectricStarter : IStarter
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public Battery Battery { get; set; }

        public AirCompressor AirCompressor
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public HydraulicPump HydraulicPump
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public IgnitionStatus Start()
        {
           return IgnitionStatus.Success;
        }
    }
}