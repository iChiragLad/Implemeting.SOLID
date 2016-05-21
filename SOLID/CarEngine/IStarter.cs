namespace CarEngine
{
    internal interface IStarter
    {
        string Brand { get; set; }
        string Model { get; set; }

        IgnitionStatus Start();
    }
}