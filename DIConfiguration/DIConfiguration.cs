using Autofac;

namespace CQRS.DIConfiguration
{
    public static class DIConfiguration
    {
        public static ContainerBuilder Configure(ContainerBuilder builder)
        {
            builder.RegisterModule<CommandsCore>();
            builder.RegisterModule<EventsCore>();
            builder.RegisterModule<QueriesModule>();
            builder.RegisterModule<CommandsModule>();
            builder.RegisterModule<EventsModule>();
            return builder;
        }
    }
}
