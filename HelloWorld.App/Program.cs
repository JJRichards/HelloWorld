using System;

namespace HelloWorld.App
{
    internal class Program
    {
        private static void Main()
        {
            var truck = new Truck(6);

            var imageCaptureService = new ImageCaptureService(new SystemClock(), new LocationService());
            truck.TakeAPhoto(imageCaptureService);

            Console.ReadKey();
        }
    }
}