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
<<<<<<< HEAD
        public HydraulicPump HydraulicPump { get; set; }
=======
>>>>>>> de4c60ee007d0d302b1a5e5b7dc835384b6760a0

        public AirCompressor AirCompressor
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
<<<<<<< HEAD

        public IgnitionStatus Start()
        {
            return (HydraulicPump.IsFilled?IgnitionStatus.Success : IgnitionStatus.Failure);
=======
        public HydraulicPump HydraulicPump { get; set; }

        public IgnitionStatus Start()
        {
            return (HydraulicPump.IsFilled ? IgnitionStatus.Success : IgnitionStatus.Failure);
>>>>>>> de4c60ee007d0d302b1a5e5b7dc835384b6760a0
        }
    }
}
