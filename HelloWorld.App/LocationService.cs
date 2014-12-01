using System;

namespace HelloWorld.App
{
    public class LocationService : ILocationService
    {
        public Location WhereAmI()
        {
            Console.WriteLine("Querying location...");
            return new Location(-27, 153);
        }
    }
}