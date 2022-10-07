using EducationCenter.Data.DbContexts;
using EducationCenter.Data.Interfaces.Teachers;
using EducationCenter.Domain.Entities;

namespace EducationCenter.Data.Repositories.Teachers
{
    public class TeacherRepository : GenericRepository<Teacher>,
        ITeacherRepository
    {
        public TeacherRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}