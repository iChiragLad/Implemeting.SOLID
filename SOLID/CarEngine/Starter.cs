namespace CarEngine
{
    internal class Starter
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public IgnitionStatus Start(Battery battery)
        {
            return (battery.IsCharged ? IgnitionStatus.Success : IgnitionStatus.Failure);
        }
    }
}
