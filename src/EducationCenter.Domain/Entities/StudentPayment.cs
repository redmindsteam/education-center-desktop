namespace EducationCenter.Domain.Entities;

public class StudentPayment : Payment
{
    public long? CourseId { get; set; }
    public virtual Course Course { get; set; }

    public long? StudentId { get; set; }
    public virtual Student Student { get; set; }

    public StudentPayment()
    {
        Course = new Course();
        Student = new Student();
    }
}
