using EducationCenter.Domain.Common;
using EducationCenter.Domain.Enums;

namespace EducationCenter.Domain.Entities;

public abstract class Payment : BaseEntity
{
    public float Amount { get; set; }

    public DateOnly ForMonth { get; set; }

    public PaymentType PaymentType { get; set; }

    public string Description { get; set; } = String.Empty;

    public DateTime PaymentDate { get; set; }
}
