using System;

namespace CarEngine
{
    internal class CarProgram
    {
        private static void Main()
        {
            //Driver has sat in the car and is ready to drive.
            //He presses the start button

            // ReSharper disable once SuggestVarOrType_SimpleTypes
            Engine engine = new Engine();

            var state = engine.Start();

            Console.WriteLine(state == IgnitionStatus.Success ? "Engine Started" : "Failed to start");

            Console.ReadKey();
        }
    }
}
