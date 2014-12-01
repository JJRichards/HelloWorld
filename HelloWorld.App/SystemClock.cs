using System;

namespace HelloWorld.App
{
    public class SystemClock : IClock
    {
        public SystemClock()
        {
            Console.WriteLine("SystemClock created");
        }

        public DateTimeOffset UtcNow
        {
            get { return DateTimeOffset.UtcNow; }
        }
    }
}