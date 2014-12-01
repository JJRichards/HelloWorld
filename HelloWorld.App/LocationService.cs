using System;

namespace HelloWorld.App
{
    public class LocationService : ILocationService
    {
        private readonly IClock _clock;

        public LocationService(IClock clock)
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