using EducationCenter.Domain.Common;
using EducationCenter.Domain.Enums;

namespace EducationCenter.Domain.Entities;

public class Course : Auditable
{
    public string Name { get; set; } = String.Empty;

    public string Language { get; set; } = String.Empty;

    public string Level { get; set; } = String.Empty;

    public float Price { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Duration { get; set; } = String.Empty;

    public string Description { get; set; } = String.Empty;

    public CourseStatus CourseStatus { get; set; }

    public long? SubjectId { get; set; }
    public virtual Subject Subject { get; set; }

    public Course()
    {
        Subject = new Subject();
    }
}
