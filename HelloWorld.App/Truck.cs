using System;

namespace HelloWorld.App
{
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
            if (IsFull) throw new InvalidOperationException("I'm full. Go away.");

            _garbageCollected++;
        }

        public bool IsFull
        {
            get { return _garbageCollected >= _capacity; }
        }
    }
}