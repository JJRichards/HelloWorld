using HelloWorld.App;
using NUnit.Framework;
using Shouldly;

namespace HelloWorld.UnitTests
{
    public class WhenATruckPicksUpLotsOfGarbage
    {
        [Test]
        public void ItShouldGetFull()
        {
            // Arrange
            const int capacity = 3;
            var truck = new Truck(capacity);

            // Act
            for (var i = 0; i < capacity; i++)
            {
                truck.PickUpGarbage();
            }

            // Assert
            truck.IsFull.ShouldBe(true);
        }
    }
}