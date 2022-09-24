namespace EducationCenter.Service.ViewModels.Subjects
{
    public class SubjectViewModel
    {
        public long Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int CountOfTeachers { get; set; }

        public int CountOfGroups { get; set; }

        public int CountOfStudents { get; set; }
    }
}