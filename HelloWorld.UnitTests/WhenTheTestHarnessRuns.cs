using NUnit.Framework;
using Shouldly;

namespace HelloWorld.UnitTests
{
    [TestFixture]
    public class WhenTheTestHarnessRuns
    {
        [Test]
        public void ThePeopleShallRejoice()
        {
        }
    }

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

    public class Truck
    {
        private int _garbageCollected;
        private readonly int _capacity;

        public Truck(int capacity)
        {
            _capacity = capacity;
        }

        public void PickUpGarbage()
        {
            _garbageCollected++;
        }

        public bool IsFull
        {
            get { return _garbageCollected >= _capacity; }
        }
    }
}