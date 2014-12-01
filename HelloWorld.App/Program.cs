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
            //var imageCaptureService = (ImageCaptureService)AutomaticFactory.Create(typeof(ImageCaptureService));
            var imageCaptureService = AutomaticFactory.Create<ImageCaptureService>();

            truck.TakeAPhoto(imageCaptureService);

            Console.ReadKey();
        }
    }

    internal class AutomaticFactory
    {
        public static T Create<T>()
        {
            var type = typeof (T);
            var instance = Create(type);
            return (T) instance;
        }

        public static object Create(Type type)
        {
            var constructor = type.GetConstructors().Single();
            var args = new List<object>();
            foreach (var p in constructor.GetParameters())
            {
                var arg = Create(p.ParameterType);
                args.Add(arg);
            }

            var instance = Activator.CreateInstance(type, args.ToArray());
            return instance;
        }
    }
}