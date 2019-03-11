using CQRS.Abstract;
using System;

namespace CQRS.Implementations
{
    public class CommandBus : ICommandBus
    {
        private readonly Func<Type, ICommandHandler> factory;

        public CommandBus(Func<Type, ICommandHandler> factory)
            => this.factory = factory;

        public void Send<TCommand>(TCommand command) where TCommand : ICommand
        {
            var commandHandler = (ICommandHandler<TCommand>)factory(typeof(TCommand));
            commandHandler.Handle(command);
        }
    }
}
