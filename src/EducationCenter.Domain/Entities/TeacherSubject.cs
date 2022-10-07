using EducationCenter.Domain.Common;

namespace EducationCenter.Domain.Entities;

public class TeacherSubject : BaseEntity
{
    public long? TeacherId { get; set; }
    public virtual Teacher Teacher { get; set; } = null!;

    public long? SubjectId { get; set; }
    public virtual Subject Subject { get; set; } = null!;

    public DateTime RegistrDate { get; set; }
}
