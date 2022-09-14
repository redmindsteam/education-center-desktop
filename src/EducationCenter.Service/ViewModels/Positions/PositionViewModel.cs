using EducationCenter.Domain.Enums;

namespace EducationCenter.Service.ViewModels.Positions;

public class PositionViewModel
{
    public long Id { get; set; }

    public string Name { get; set; } = String.Empty;

    public int CountStaffsOfPosition { get; set; }

    public string Status { get; set; } = String.Empty;
}
