namespace CarEngine
{
    internal interface IStarter
    {
        string Brand { get; set; }
        string Model { get; set; }
        Battery Battery { get; set; }
<<<<<<< HEAD
        HydraulicPump HydraulicPump { get; set; }
        AirCompressor AirCompressor { get; set; }
=======
        AirCompressor AirCompressor { get; set; }
        HydraulicPump HydraulicPump { get; set; }
>>>>>>> de4c60ee007d0d302b1a5e5b7dc835384b6760a0
        IgnitionStatus Start();
    }
}