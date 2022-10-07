using EducationCenter.Domain.Common;

namespace EducationCenter.Domain.Entities;

public class CourseStudent : BaseEntity
{
    public long? CourseId { get; set; }
    public virtual Course Course { get; set; } = null!;

    public long? StudentId { get; set; }
    public virtual Student Student { get; set; } = null!;

    public DateTime RegistrDate { get; set; }
}
