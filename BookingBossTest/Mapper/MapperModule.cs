using System.Collections.Generic;
using Autofac;
using AutoMapper;

namespace BookingBossTest.Mapper
{
    public class MapperModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //register all profile classes in the calling assembly
            builder.RegisterAssemblyTypes(typeof(MapperModule).Assembly).As<Profile>();

            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                foreach (var profile in ctx.Resolve<IEnumerable<Profile>>())
                {
                    cfg.AddProfile(profile);
                }
            })).As<IConfigurationProvider>().SingleInstance();

            builder.Register(ctx => ctx.Resolve<IConfigurationProvider>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }
    }
}