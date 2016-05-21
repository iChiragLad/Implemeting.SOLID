using System;

namespace CarEngine
{
    internal class Engine
    {
        private readonly IStarter _starter;

        public Engine()
        {
            _starter = new ElectricStarter {Battery = new Battery()};
        }

        public IgnitionStatus Start()
        {
            return (_starter.Start());
        }
    }
}
