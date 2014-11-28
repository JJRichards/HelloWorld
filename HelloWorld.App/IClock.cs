using System;

namespace HelloWorld.App
{
    public interface IClock
    {
        DateTimeOffset UtcNow { get; }
    }
}