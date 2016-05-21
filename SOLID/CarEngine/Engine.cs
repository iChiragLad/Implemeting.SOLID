namespace CarEngine
{
    internal class Engine
    {
        private readonly IStarter _starter;

        public Engine()
        {
            _starter = new ElectricStarter();
        }
        public IgnitionStatus Start()
        {
            return (_starter.Start());
        }
    }
}
