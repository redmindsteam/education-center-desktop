using EducationCenter.Data.DbContexts;
using EducationCenter.Data.Interfaces.Employees;
using EducationCenter.Domain.Entities;

namespace EducationCenter.Data.Repositories.Employees
{
    public class EmployeeRepository : GenericRepository<Employee>,
        IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}