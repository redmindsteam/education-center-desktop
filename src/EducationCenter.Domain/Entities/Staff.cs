using EducationCenter.Domain.Enums;

namespace EducationCenter.Domain.Entities;

public class Staff : Person
{
    public float Salary { get; set; }

    public string CardNumber { get; set; } = String.Empty;

    public DateTime FirstWorkDate { get; set; }

    public StaffStatus Status { get; set; }
}
