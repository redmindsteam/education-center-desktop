namespace EducationCenter.Domain.Entities;

public class EmployeePayment : Payment
{
    public long? EmployeeId { get; set; }
    public virtual Employee Employee { get; set; }

    public EmployeePayment()
    {
        Employee = new Employee();
    }
}
