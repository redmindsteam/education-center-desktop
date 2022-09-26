using System;

namespace EducationCenter.Service.ViewModels.Teachers
{
    public class TeacherPaymentViewModel
    {
        public long Id { get; set; }

        public string TeacherName { get; set; } = String.Empty;

        public string CourseName { get; set; } = String.Empty;

        public float Amount { get; set; }

        public string ForMonth { get; set; } = String.Empty;

        public string PaymentDate { get; set; } = String.Empty;
    }
}