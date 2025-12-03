using Persona.Domain.Common;

namespace Persona.Domain.Personas.Events
{
    public sealed record PersonaCreatedDomainEvent(Guid PersonaId) : IDomainEvent
    {
        public DateTime OccurredOn { get; } = DateTime.UtcNow;
    }
}
