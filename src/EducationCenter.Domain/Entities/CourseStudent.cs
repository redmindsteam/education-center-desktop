using EducationCenter.Domain.Common;

namespace EducationCenter.Domain.Entities;

public class CourseStudent : BaseEntity
{
    public long? CourseId { get; set; }
    public virtual Course Course { get; set; }

    public long? StudentId { get; set; }
    public virtual Student Student { get; set; }

    public DateTime RegistrDate { get; set; }

    public CourseStudent()
    {
        Course = new Course();
        Student = new Student();
    }
}
