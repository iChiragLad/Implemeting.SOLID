namespace CarEngine
{
    internal class Starter
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public IgnitionStatus Start()
        {
            //Logic to start the engine
            return IgnitionStatus.Success;
        }
    }
}
