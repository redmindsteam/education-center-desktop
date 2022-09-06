using EducationCenter.Domain.Common;

namespace EducationCenter.Domain.Entities;

public abstract class Person : Auditable
{
    public string FirstName { get; set; } = String.Empty;

    public string LastName { get; set; } = String.Empty;

    public string MiddleName { get; set; } = String.Empty;

    public DateTime BirthDate { get; set; }

    public string PhoneNumber { get; set; } = String.Empty;

    public string Email { get; set; } = String.Empty;

    public string Description { get; set; } = String.Empty;

    public string ImagePath { get; set; } = String.Empty;

    public string Address { get; set; } = String.Empty;
}
