using Autofac;

namespace BookingBoss.Service
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(t => t.Name.EndsWith("Service"))
                .PropertiesAutowired()
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
