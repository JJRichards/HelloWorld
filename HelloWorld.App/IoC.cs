using Autofac;

namespace HelloWorld.App
{
    public static class IoC
    {
        public static IContainer LetThereBeIoC()
        {
            var builder = new ContainerBuilder();
            var thisAssembly = typeof (IoC).Assembly;
            builder.RegisterAssemblyModules(thisAssembly);
            return builder.Build();
        }
    }
}