using System;

namespace HelloWorld.App
{
    public class ImageCaptureServiceFactory
    {
        public static IImageCaptureService Create()
        {
            throw new NotImplementedException();
            //var locationService = new LocationService();
            //var locationService = LocationServiceFactory.Create();
            //var imageCaptureService = new ImageCaptureService(new SystemClock(), locationService);
            //return imageCaptureService;
        }
    }
}