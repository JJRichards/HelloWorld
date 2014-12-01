namespace HelloWorld.App
{
    public class LocationServiceFactory
    {
        public static ILocationService Create()
        {
            return new LocationService();
        }
    }
}