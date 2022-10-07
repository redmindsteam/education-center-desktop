using EducationCenter.Data.DbContexts;
using EducationCenter.Data.Interfaces.Employees;
using EducationCenter.Domain.Entities;
using System;

namespace EducationCenter.Data.Repositories.Employees
{
    public class EmployeePaymentRepository : GenericRepository<EmployeePayment>,
        IEmployeePaymentRepository
    {
        public EmployeePaymentRepository(AppDbContext appDbContext) 
            : base(appDbContext)
        {
        }
    }
}