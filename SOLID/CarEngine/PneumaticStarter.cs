namespace CarEngine
{
    internal class PneumaticStarter : IStarter
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public IgnitionStatus Start()
        {
            return IgnitionStatus.Success;
        }
    }
}
