using Autofac;
using CQRS.Abstract;
using CQRS.Implementations;

namespace CQRS.DIConfiguration
{
    public class EventsCore : Module
    {
        protected override void Load(ContainerBuilder builder)
            => builder.RegisterType<EventBus>()
                .As<IEventBus>()
                .InstancePerLifetimeScope();
    }
}
