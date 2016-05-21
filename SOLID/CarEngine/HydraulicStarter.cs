using System;

namespace CarEngine
{
    internal class HydraulicStarter : IHydraulicStarter
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public HydraulicPump HydraulicPump { get; set; }

        public IgnitionStatus Start()
        {
            return (HydraulicPump.IsFilled ? IgnitionStatus.Success : IgnitionStatus.Failure);
        }
    }
}
