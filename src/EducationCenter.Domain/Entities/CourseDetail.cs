using EducationCenter.Domain.Common;

namespace EducationCenter.Domain.Entities;

public class CourseDetail : BaseEntity
{
    public long? CourseId { get; set; }
    public virtual Course Course { get; set; }

    public string StartTime { get; set; } = String.Empty;

    public DayOfWeek DayOfWeek { get; set; }

    public string EndTime { get; set; } = String.Empty;

    public string Room { get; set; } = String.Empty;

    public CourseDetail()
    {
        Course = new Course();
    }
}
