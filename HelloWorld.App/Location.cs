namespace HelloWorld.App
{
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

        public override string ToString()
        {
            return string.Format("({0}, {1})", _latitude, _longitude);
        }
    }
}