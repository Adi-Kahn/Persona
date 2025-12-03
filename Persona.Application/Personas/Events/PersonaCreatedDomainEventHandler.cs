using Persona.Application.Abstractions.Messaging;
using Persona.Domain.Personas.Events;

namespace Persona.Application.Personas.Events;

public sealed class PersonaCreatedDomainEventHandler : IDomainEventHandler<PersonaCreatedDomainEvent>
{
    public Task HandleAsync(PersonaCreatedDomainEvent domainEvent, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
