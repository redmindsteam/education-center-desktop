namespace EducationCenter.Domain.Entities;

public class TeacherPayment : Payment
{
    public long? CourseId { get; set; }
    public virtual Course Course { get; set; } = null!;

    public long? TeacherId { get; set; }
    public virtual Teacher Teacher { get; set; } = null!;
}
