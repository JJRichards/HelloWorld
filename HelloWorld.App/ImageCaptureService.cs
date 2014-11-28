using System;

namespace HelloWorld.App
{
    public class ImageCaptureService : IImageCaptureService
    {
        private readonly IClock _clock;

        public ImageCaptureService(IClock clock)
        {
            _clock = clock;
        }

        public Photo CapturePhoto()
        {
            var timestamp = _clock.UtcNow;

            var photo = new Photo();
            throw new NotImplementedException();
        }
    }
}