using EducationCenter.Domain.Common;

namespace EducationCenter.Domain.Entities;

public class Subject : Auditable
{
    public string Name { get; set; } = String.Empty;
}
