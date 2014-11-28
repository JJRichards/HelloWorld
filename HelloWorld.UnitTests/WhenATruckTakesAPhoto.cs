using System;
using HelloWorld.App;
using NUnit.Framework;
using Shouldly;

namespace HelloWorld.UnitTests
{
    public class WhenATruckTakesAPhoto
    {
        [Test]
        public void ANewPhotoShouldAppearInTheTrucksPhotosCollection()
        {
            var truck = new Truck(6);

            var imageCaptureService = new LyingCheatingImageCaptureService();
            truck.TakeAPhoto(imageCaptureService);

            truck.Photos.Count.ShouldBe(1);
        }
    }
}