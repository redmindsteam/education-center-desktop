using EducationCenter.Domain.Enums;

namespace EducationCenter.Domain.Entities;

public class Student : Person
{
    public StudentStatus Status { get; set; }
}
