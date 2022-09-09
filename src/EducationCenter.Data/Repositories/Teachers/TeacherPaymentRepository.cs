using EducationCenter.Data.Interfaces.Teachers;
using EducationCenter.Domain.Entities;

namespace EducationCenter.Data.Repositories.Teachers
{
    public class TeacherPaymentRepository : GenericRepository<TeacherPayment>,
        ITeacherPaymentRepository
    {
    }
}