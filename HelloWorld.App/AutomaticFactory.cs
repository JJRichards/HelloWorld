using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld.App
{
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
            var typeWeActuallyWant = FigureOutWhatTypeWeWant(type);

            var constructor = typeWeActuallyWant.GetConstructors().Single();
            var args = new List<object>();
            foreach (var p in constructor.GetParameters())
            {
                var arg = Create(p.ParameterType);
                args.Add(arg);
            }

            var instance = Activator.CreateInstance(typeWeActuallyWant, args.ToArray());
            return instance;
        }

        private static Type FigureOutWhatTypeWeWant(Type type)
        {
            var concreteType = type.Assembly
                                   .DefinedTypes
                                   .Where(t => type.IsAssignableFrom(t))
                                   .Where(t => !t.IsInterface)
                                   .Where(t => !t.IsAbstract)
                                   .First();

            return concreteType;
        }
    }
}