namespace CarEngine
{
    internal class Engine
    {
        private readonly IStarter _starter;
        private readonly Battery _battery;

        public Engine()
        {
            _starter = new ElectricStarter();
            _battery = new Battery();
        }
        public IgnitionStatus Start()
        {
            return (_starter.Start());
        }
    }
}
