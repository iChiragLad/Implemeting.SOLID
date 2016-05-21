namespace CarEngine
{
    internal interface IStarter
    {
        string Brand { get; set; }
        string Model { get; set; }
        Battery Battery { get; set; }
        HydraulicPump HydraulicPump { get; set; }
        AirCompressor AirCompressor { get; set; }
        IgnitionStatus Start();
    }
}