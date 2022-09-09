namespace EducationCenter.Domain.Entities;

public class Teacher : Staff
{
    public Int16 Expirience { get; set; }

    public string Level { get; set; } = String.Empty;
}
