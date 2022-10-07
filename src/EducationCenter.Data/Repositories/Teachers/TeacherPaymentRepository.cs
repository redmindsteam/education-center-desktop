using EducationCenter.Data.DbContexts;
using EducationCenter.Data.Interfaces.Teachers;
using EducationCenter.Domain.Entities;

namespace EducationCenter.Data.Repositories.Teachers
{
    public class TeacherPaymentRepository : GenericRepository<TeacherPayment>,
        ITeacherPaymentRepository
    {
        public TeacherPaymentRepository(AppDbContext appDbContext) 
            : base(appDbContext)
        {
        }
    }
}