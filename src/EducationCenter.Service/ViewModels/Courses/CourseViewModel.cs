using EducationCenter.Domain.Enums;
using System;

namespace EducationCenter.Service.ViewModels.Courses
{
    public class CourseViewModel
    {
        public long Id { get; set; }

        public string Name { get; set; } = String.Empty;

        public string SubjectName { get; set; } = String.Empty;

        public string Language { get; set; } = String.Empty;

        public string Level { get; set; } = String.Empty;

        public float Price { get; set; }

        public CourseStatus Status { get; set; }
    }
}