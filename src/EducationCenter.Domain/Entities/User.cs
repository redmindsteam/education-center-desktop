using EducationCenter.Domain.Common;
using EducationCenter.Domain.Enums;
using System;

namespace EducationCenter.Domain.Entities;

public class User : Auditable
{
    public string FirstName { get; set; } = String.Empty;

    public string LastName { get; set; } = String.Empty;

    public string Email { get; set; } = String.Empty;

    public string Salt { get; set; } = String.Empty;

    public string PasswordHash { get; set; } = String.Empty;

    public UserRole Role { get; set; }
}

