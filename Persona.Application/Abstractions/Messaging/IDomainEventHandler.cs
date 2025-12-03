using Persona.Domain.Common;

namespace Persona.Application.Abstractions.Messaging;

public interface IDomainEventHandler<in TEvent> where TEvent : IDomainEvent
{
    Task HandleAsync(TEvent domainEvent, CancellationToken cancellationToken = default);
}
