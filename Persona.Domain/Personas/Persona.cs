using Persona.Domain.Common;
using Persona.Domain.Personas.Events;
using System.Net.NetworkInformation;

namespace Persona.Domain.Personas;

public sealed class Persona : AggregateRoot
{
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string PhoneNumber { get; private set; } = string.Empty;
    public DateOnly DateOfBirth { get; private set; }
    public string Description { get; private set; } = string.Empty;

    private Persona() { }

    private Persona(
       Guid id,
       string firstName,
       string lastName,
       string email,
       string phoneNumber,
       DateOnly dateOfBirth,
       string description)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        DateOfBirth = dateOfBirth;
        Description = description;
    }

    public static Persona New(string firstName, string lastName, string email, string phoneNumber, DateOnly dateOfBirth, string description)
    {
        var persona = new Persona(
            Guid.NewGuid(),
            firstName,
            lastName,
            email,
            phoneNumber,
            dateOfBirth,
            description);

        persona.AddDomainEvent(new PersonaCreatedDomainEvent(persona.Id));

        return persona;
    }
    
    public void UpdateContactInformation(string email, string phoneNumber)
    {
        Email = email;
        PhoneNumber = phoneNumber;

        AddDomainEvent(new PersonaContactInformationUpdatedDomainEvent(Id, email, phoneNumber));
    }
}   
