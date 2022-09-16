using EducationCenter.Domain.Enums;
using System;

namespace EducationCenter.Service.ViewModels.Students
{
    public class StudentViewModel
    {
        public long Id { get; set; }

        public string FullName { get; set; } = String.Empty;

        public string Email { get; set; } = String.Empty;

        public string PhoneNumber { get; set; } = String.Empty;

        public int CountOfCourses { get; set; }

        public StudentStatus Status { get; set; }
    }
}