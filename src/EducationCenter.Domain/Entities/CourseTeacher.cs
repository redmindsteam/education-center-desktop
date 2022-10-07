using EducationCenter.Domain.Common;

namespace EducationCenter.Domain.Entities;

public class CourseTeacher : BaseEntity
{
    public long? CourseId { get; set; }
    public virtual Course Course { get; set; } = null!;

    public long? TeacherId { get; set; }
    public virtual Teacher Teacher { get; set; } = null!;

    public string Role { get; set; } = String.Empty;

    public DateTime RegistrDate { get; set; }

}
