using System;

namespace CarEngine
{
    internal class ElectricStarter : IElectricStarter
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public Battery Battery { get; set; }

        public IgnitionStatus Start()
        {
            return (Battery.IsCharged ? IgnitionStatus.Success : IgnitionStatus.Failure);
        }
    }
}