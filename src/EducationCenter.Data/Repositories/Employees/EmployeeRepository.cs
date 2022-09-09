using EducationCenter.Data.Interfaces.Employees;
using EducationCenter.Domain.Entities;

namespace EducationCenter.Data.Repositories.Employees
{
    public class EmployeeRepository : GenericRepository<Employee>,
        IEmployeeRepository
    {
    }
}