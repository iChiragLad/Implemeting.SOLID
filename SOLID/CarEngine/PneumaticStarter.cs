﻿using System;

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
<<<<<<< HEAD
=======
        public AirCompressor AirCompressor { get; set; }
>>>>>>> de4c60ee007d0d302b1a5e5b7dc835384b6760a0

        public HydraulicPump HydraulicPump
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
<<<<<<< HEAD
        public AirCompressor AirCompressor { get; set; }

        public IgnitionStatus Start()
        {
            return (AirCompressor.IsLoaded?IgnitionStatus.Success : IgnitionStatus.Failure);
=======

        public IgnitionStatus Start()
        {
            return (AirCompressor.IsLoaded? IgnitionStatus.Success : IgnitionStatus.Failure);
>>>>>>> de4c60ee007d0d302b1a5e5b7dc835384b6760a0
        }
    }
}
