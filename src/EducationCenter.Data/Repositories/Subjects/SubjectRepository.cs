using EducationCenter.Data.DbContexts;
using EducationCenter.Data.Interfaces.Subjects;
using EducationCenter.Domain.Entities;

namespace EducationCenter.Data.Repositories.Subjects
{
    public class SubjectRepository : GenericRepository<Subject>,
        ISubjectRepository
    {
        public SubjectRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}