using Autofac;

namespace HelloWorld.App
{
    public class AllTheThingsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterAssemblyTypes(ThisAssembly).AsImplementedInterfaces();

            builder.RegisterType<SystemClock>()
                   .AsImplementedInterfaces()
                   .SingleInstance();
        }
    }
}