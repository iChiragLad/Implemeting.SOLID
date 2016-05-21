using System;

namespace CarEngine
{
    internal class HydraulicStarter : IStarter
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Battery Battery
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public HydraulicPump HydraulicPump { get; set; }

        public AirCompressor AirCompressor
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public IgnitionStatus Start()
        {
            return (HydraulicPump.IsFilled?IgnitionStatus.Success : IgnitionStatus.Failure);
        }
    }
}
