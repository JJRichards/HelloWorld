using System;

namespace HelloWorld.App
{
    public class ImageCaptureService : IImageCaptureService
    {
        private readonly IClock _clock;
        private readonly ILocationService _locationService;

        public ImageCaptureService(IClock clock, ILocationService locationService)
        {
            _clock = clock;
            _locationService = locationService;
        }

        public Photo CapturePhoto()
        {
            var timestamp = _clock.UtcNow;
            var location = _locationService.WhereAmI();

            var photo = new Photo();
            throw new NotImplementedException();
        }
    }

    public interface ILocationService
    {
        Location WhereAmI();
    }

    public class Location
    {
        private readonly decimal _latitude;
        private readonly decimal _longitude;

        public Location(decimal latitude, decimal longitude)
        {
            _latitude = latitude;
            _longitude = longitude;
        }

        public decimal Latitude
        {
            get { return _latitude; }
        }

        public decimal Longitude
        {
            get { return _longitude; }
        }
    }
}