using CQRS.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CQRS.Implementations
{
    public class EventBus : IEventBus
    {
        private readonly Func<Type, IEnumerable<IEventHandler>> factory;

        public EventBus(Func<Type, IEnumerable<IEventHandler>> factory)
            => this.factory = factory;

        public void Publish<TEvent>(TEvent @event) where TEvent : IEvent
        {
            var eventHandlers = factory(typeof(TEvent)).Cast<IEventHandler<TEvent>>();

            foreach (var eventHandler in eventHandlers)
            {
                eventHandler.Handle(@event);
            }
        }
    }
}
