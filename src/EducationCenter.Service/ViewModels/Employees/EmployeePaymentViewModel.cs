using System;

namespace EducationCenter.Service.ViewModels.Employees
{
    public class EmployeePaymentViewModel
    {
        public long Id { get; set; }

        public string EmployeeName { get; set; } = String.Empty;

        public string Position { get; set; } = String.Empty;

        public float Amount { get; set; }

        public string ForMonth { get; set; } = String.Empty;

        public string PaymentDate { get; set; } = String.Empty;
    }
}