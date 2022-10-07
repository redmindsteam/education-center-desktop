using EducationCenter.Data.DbContexts;
using EducationCenter.Data.Interfaces.Students;
using EducationCenter.Domain.Entities;

namespace EducationCenter.Data.Repositories.Students
{
    public class StudentPaymentRepository : GenericRepository<StudentPayment>,
        IStudentPaymentRepository
    {
        public StudentPaymentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}