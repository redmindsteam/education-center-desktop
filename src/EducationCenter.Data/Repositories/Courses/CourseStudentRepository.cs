using EducationCenter.Data.DbContexts;
using EducationCenter.Data.Interfaces.Courses;
using EducationCenter.Domain.Entities;

namespace EducationCenter.Data.Repositories.Courses
{
    public class CourseStudentRepository : GenericRepository<CourseStudent>,
        ICourseStudentRepository
    {
        public CourseStudentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}