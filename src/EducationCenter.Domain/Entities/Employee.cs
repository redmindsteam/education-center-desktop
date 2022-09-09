namespace EducationCenter.Domain.Entities;

public class Employee : Staff
{
    public long? PositionId { get; set; }
    public virtual Position Position { get; set; }

    public Employee()
    {
        Position = new Position();
    }
}
