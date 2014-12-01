using System;
using System.Threading;
using Autofac;

namespace HelloWorld.App
{
    internal class Program
    {
        private static void Main()
        {
            using (var container = IoC.LetThereBeIoC())
            {
                var truck = new Truck(6);

                //var imageCaptureService = new ImageCaptureService(new SystemClock(), new LocationService());
                //var imageCaptureService = ImageCaptureServiceFactory.Create();
                //var imageCaptureService = (ImageCaptureService)AutomaticFactory.Create(typeof(ImageCaptureService));
                //var imageCaptureService = AutomaticFactory.Create<ImageCaptureService>();
                //var imageCaptureService = AutomaticFactory.Create<IImageCaptureService>();
                var imageCaptureService = container.Resolve<IImageCaptureService>();

                truck.TakeAPhoto(imageCaptureService);

                Console.ReadKey();
            }
        }
    }
}