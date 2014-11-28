using System;
using HelloWorld.App;
using NUnit.Framework;

namespace HelloWorld.UnitTests
{
    public class AFullTruck
    {
        [Test]
        [ExpectedException(typeof (InvalidOperationException))]
        public void CannotPickUpMoreGarbage()
        {
            // Arrange
            const int capacity = 5;
            var truck = new Truck(capacity);
            for (var i = 0; i < capacity; i++)
            {
                truck.PickUpGarbage();
            }

            // Act
            truck.PickUpGarbage();
        }
    }
}