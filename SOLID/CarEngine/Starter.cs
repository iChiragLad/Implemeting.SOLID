namespace CarEngine
{
    internal class Starter
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public StarterType StarterType { get; set; }
        public IgnitionStatus Start(Battery battery)
        {
            if (StarterType == StarterType.Electric)
            {
                return battery.IsCharged ? IgnitionStatus.Success : IgnitionStatus.Failure;
            }
            if(StarterType == StarterType.Hydraulic)
            {
                return  IgnitionStatus.Success;
            }
            else
            {
                return IgnitionStatus.Success;
            }
        }
    }
}
