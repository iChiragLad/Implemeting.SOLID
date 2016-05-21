namespace CarEngine
{
    internal class HydraulicStarter : IStarter
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public IgnitionStatus Start()
        {
            return IgnitionStatus.Success;
        }
    }
}
