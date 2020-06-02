using System;

namespace Q6
{
    internal interface ITransporter
    {
        void Access();
    }

    internal class Taxi : ITransporter
    {
        public void Access() =>
            Console.WriteLine("Traveling with taxi");
    }

    internal class Bus : ITransporter
    {
        public void Access() =>
            Console.WriteLine("Traveling with bus");
    }

    class Train : ITransporter
    {
        public void Access() =>
            Console.WriteLine("Traveling with train");
    }

    internal class Transportation
    {
        readonly ITransporter _tporter;

        public Transportation(ITransporter t) => _tporter = t;


        public void Access() => _tporter.Access();
    }
}