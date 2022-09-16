using EducationCenter.Domain.Enums;

namespace EducationCenter.Service.ViewModels.Teachers
{
    public class TeacherViewModel
    {
        public long Id { get; set; }

        public string FullName { get; set; } = String.Empty;

        public string Level { get; set; } = String.Empty;

        public int Age { get; set; }

        public string PhoneNumber { get; set; } = String.Empty;

        public int CountOfCourses { get; set; }

        public StaffStatus Status { get; set; }
    }
}