using EducationCenter.Data.DbContexts;
using EducationCenter.Data.Interfaces.Courses;
using EducationCenter.Domain.Entities;

namespace EducationCenter.Data.Repositories.Courses
{
    public class CourseTeacherRepository : GenericRepository<CourseTeacher>,
        ICourseTeacherRepository
    {
        public CourseTeacherRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}