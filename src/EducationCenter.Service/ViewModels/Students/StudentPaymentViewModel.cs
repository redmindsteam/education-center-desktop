using System;

namespace EducationCenter.Service.ViewModels.Students
{
    public class StudentPaymentViewModel
    {
        public long Id { get; set; }

        public string StudentName { get; set; } = String.Empty;

        public string CourseName { get; set; } = String.Empty;

        public float Amount { get; set; }

        public string ForMonth { get; set; } = String.Empty;

        public string PaymentDate { get; set; } = String.Empty;
    }
}