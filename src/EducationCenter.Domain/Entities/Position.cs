using EducationCenter.Domain.Common;
using EducationCenter.Domain.Enums;

namespace EducationCenter.Domain.Entities;

public class Position : Auditable
{
    public string Name { get; set; } = String.Empty;

    public PositionStatus Status { get; set; }
}
