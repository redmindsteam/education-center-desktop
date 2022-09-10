using EducationCenter.Data.Interfaces.Courses;
using EducationCenter.Domain.Entities;

namespace EducationCenter.Data.Repositories.Courses
{
    public class CourseRepository : GenericRepository<Course>,
        ICourseRepository
    {
    }
}