using EducationCenter.Domain.Common;

namespace EducationCenter.Domain.Entities;

public abstract class Person : Auditable
{
    public string FirstName { get; set; } = String.Empty;

    public string LastName { get; set; } = String.Empty;

    public string? MiddleName { get; set; } 

    public DateTime? BirthDate { get; set; }

    public string PhoneNumber { get; set; } = String.Empty;

    public string Email { get; set; } = String.Empty;

    public string? Description { get; set; }

    public string? ImagePath { get; set; }

    public string? Address { get; set; }
}
