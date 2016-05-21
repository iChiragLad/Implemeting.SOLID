using System.Security.Cryptography.X509Certificates;

namespace CarEngine
{
    internal class Engine
    {
        private readonly Starter _starter;
        private readonly Battery _battery;

        public Engine()
        {
            _starter = new Starter();
            _battery = new Battery();
        }
        public IgnitionStatus Start()
        {
            return (_starter.Start(_battery));
        }
    }
}
