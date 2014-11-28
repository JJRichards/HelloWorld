using HelloWorld.App;

namespace HelloWorld.UnitTests
{
    public class LyingCheatingImageCaptureService : IImageCaptureService
    {
        public Photo CapturePhoto()
        {
            return new Photo();
        }
    }
}