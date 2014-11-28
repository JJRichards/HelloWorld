using System;
using System.Collections.Generic;

namespace HelloWorld.App
{
    public class Truck
    {
        private int _garbageCollected;
        private readonly int _capacity;

        public Truck(int capacity)
        {
            _capacity = capacity;
            Photos = new List<Photo>();
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

        public ICollection<Photo> Photos { get; protected set; }

        public void TakeAPhoto(IImageCaptureService imageCaptureService)
        {
            var photo = imageCaptureService.CapturePhoto();
            Photos.Add(photo);
        }
    }
}