namespace HelloWorld.App
{
    internal class Program
    {
        private static void Main()
        {
            var truck = new Truck(6);

            var realImageCaptureService = new ImageCaptureService(new SystemClock());
            truck.TakeAPhoto(realImageCaptureService);
        }
    }
}