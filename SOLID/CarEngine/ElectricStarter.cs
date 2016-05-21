using System;

namespace CarEngine
{
    internal class ElectricStarter : IStarter
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public Battery Battery { get; set; }

<<<<<<< HEAD
        public HydraulicPump HydraulicPump
        {
            get { throw new NotImplementedException();}
            set { throw new NotImplementedException();}
        }

        public AirCompressor AirCompressor
=======
        public AirCompressor AirCompressor
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public HydraulicPump HydraulicPump
>>>>>>> de4c60ee007d0d302b1a5e5b7dc835384b6760a0
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public IgnitionStatus Start()
        {
           return (Battery.IsCharged?IgnitionStatus.Success : IgnitionStatus.Failure);
        }
    }
}