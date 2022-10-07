using EducationCenter.Data.DbContexts;
using EducationCenter.Data.Interfaces.Teachers;
using EducationCenter.Domain.Entities;
using System;

namespace EducationCenter.Data.Repositories.Teachers
{
    public class TeacherSubjectRepository : GenericRepository<TeacherSubject>,
        ITeacherSubjectRepository
    {
        public TeacherSubjectRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}