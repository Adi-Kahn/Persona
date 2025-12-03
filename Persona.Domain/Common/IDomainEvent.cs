namespace Persona.Domain.Common;

public interface IDomainEvent
{
    DateTime OccurredOn { get; }
}
