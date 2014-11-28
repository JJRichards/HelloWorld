using System;
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
            var truck = new Truck();

            // Act
            truck.PickUpGarbage();
            truck.PickUpGarbage();
            truck.PickUpGarbage();

            // Assert
            truck.IsFull.ShouldBe(true);
        }
    }

    public class Truck
    {
        private int _garbageCollected;

        public void PickUpGarbage()
        {
            _garbageCollected++;
        }

        public bool IsFull
        {
            get { return _garbageCollected >= 3; }
        }
    }
}