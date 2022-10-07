using EducationCenter.Domain.Common;

namespace EducationCenter.Domain.Entities;

public class CourseDetail : BaseEntity
{
    public long? CourseId { get; set; }
    public virtual Course Course { get; set; } = null!;

    public TimeOnly StartTime { get; set; }

    public DayOfWeek DayOfWeek { get; set; }

    public TimeOnly EndTime { get; set; }

    public string Room { get; set; } = String.Empty;
}
