using Autofac;
using CQRS.Abstract;
using CQRS.Implementations;

namespace CQRS.DIConfiguration
{
    public class CommandsCore : Module
    {
        protected override void Load(ContainerBuilder builder)
            => builder.RegisterType<CommandBus>()
                .As<ICommandBus>()
                .InstancePerLifetimeScope();
    }
}
