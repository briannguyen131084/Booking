using Autofac;

namespace BookingBoss.Infrastructure
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(BookingBossContext)).As(typeof(IContext)).InstancePerLifetimeScope();
        }
    }
}
