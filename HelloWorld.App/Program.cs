using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld.App
{
    internal class Program
    {
        private static void Main()
        {
            var truck = new Truck(6);

            //var imageCaptureService = new ImageCaptureService(new SystemClock(), new LocationService());
            //var imageCaptureService = ImageCaptureServiceFactory.Create();
            var imageCaptureService = (ImageCaptureService)AutomaticFactory.Create(typeof(ImageCaptureService));

            truck.TakeAPhoto(imageCaptureService);

            Console.ReadKey();
        }
    }

    internal class AutomaticFactory
    {
        public static object Create(Type type)
        {
            var constructor = type.GetConstructors().Single();
            var args = new List<object>();
            foreach (var p in constructor.GetParameters())
            {
                var arg = Activator.CreateInstance(p.ParameterType);
                args.Add(arg);
            }

            var instance = Activator.CreateInstance(type, args.ToArray());
            return instance;
        }
    }
}