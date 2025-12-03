using Persona.Domain.Common;

namespace Persona.Domain.Personas.Events;

public sealed record PersonaContactInformationUpdatedDomainEvent(Guid PersonaId, string Email, string PhoneNumber) : IDomainEvent
{
    public DateTime OccurredOn { get; } = DateTime.UtcNow;
}