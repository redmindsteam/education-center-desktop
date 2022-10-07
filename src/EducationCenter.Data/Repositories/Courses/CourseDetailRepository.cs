using EducationCenter.Data.DbContexts;
using EducationCenter.Data.Interfaces.Courses;
using EducationCenter.Domain.Entities;

namespace EducationCenter.Data.Repositories.Courses
{
    public class CourseDetailRepository : GenericRepository<CourseDetail>,
        ICourseDetailRepository
    {
        public CourseDetailRepository(AppDbContext appDbContext) 
            : base(appDbContext)
        {
        }
    }
}