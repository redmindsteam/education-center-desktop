using EducationCenter.Data.Interfaces.Courses;
using EducationCenter.Domain.Entities;

namespace EducationCenter.Data.Repositories.Courses
{
    public class CourseStudentRepository : GenericRepository<CourseStudent>,
        ICourseStudentRepository
    {
    }
}