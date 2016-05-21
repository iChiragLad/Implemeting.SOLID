using System;

namespace CarEngine
{
    internal class Engine
    {
        private readonly IStarter _starter;

        public Engine()
        {
<<<<<<< HEAD
            _starter = new ElectricStarter {Battery = new Battery()};
=======
            _starter = new ElectricStarter();
>>>>>>> de4c60ee007d0d302b1a5e5b7dc835384b6760a0
        }
        public IgnitionStatus Start()
        {
            Console.WriteLine("Battery : " + _starter.Battery.IsCharged);
            return (_starter.Start());
        }
    }
}
