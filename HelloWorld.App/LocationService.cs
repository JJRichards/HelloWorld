using System;

namespace HelloWorld.App
{
    public class LocationService : ILocationService
    {
        private readonly SystemClock _clock;

        public LocationService(SystemClock clock)
        {
            _clock = clock;
        }

        public Location WhereAmI()
        {
            Console.WriteLine("Querying location...");
            return new Location(-27, 153);
        }
    }
}