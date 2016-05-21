namespace CarEngine
{
    internal class Starter
    {
        private IStarter _starter;
        public string Brand { get; set; }
        public string Model { get; set; }

        public Starter()
        {
            _starter = new ElectricStarter();
        }
        public IgnitionStatus Start(Battery battery)
        {
            return _starter.Start();
        }
    }
}
