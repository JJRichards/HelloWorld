using System;

namespace HelloWorld.App
{
    public class ImageCaptureService : IImageCaptureService
    {
        private readonly IClock _clock;
        private readonly ILocationService _locationService;
        private readonly CaptureSource _captureSource;

        public ImageCaptureService(SystemClock clock, LocationService locationService, CaptureSource captureSource)
        {
            _clock = clock;
            _locationService = locationService;
            _captureSource = captureSource;
        }

        public Photo CapturePhoto()
        {
            var timestamp = _clock.UtcNow;
            var location = _locationService.WhereAmI();

            Console.WriteLine("I took a photo at {0} {1}.", timestamp, location);

            return new Photo();
        }
    }
}