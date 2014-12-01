namespace HelloWorld.App
{
    internal class Program
    {
        private static void Main()
        {
            var truck = new Truck(6);

            var clock = new SystemClock();
            var locationService = new LocationService();
            var imageCaptureService = new ImageCaptureService(clock, locationService);
            truck.TakeAPhoto(imageCaptureService);
        }
    }
}