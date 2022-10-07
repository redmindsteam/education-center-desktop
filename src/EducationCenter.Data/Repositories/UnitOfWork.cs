using EducationCenter.Data.DbContexts;
using EducationCenter.Data.Interfaces;
using EducationCenter.Data.Interfaces.Courses;
using EducationCenter.Data.Interfaces.Employees;
using EducationCenter.Data.Interfaces.Positions;
using EducationCenter.Data.Interfaces.Students;
using EducationCenter.Data.Interfaces.Subjects;
using EducationCenter.Data.Interfaces.Teachers;
using EducationCenter.Data.Interfaces.Users;
using EducationCenter.Data.Repositories.Courses;
using EducationCenter.Data.Repositories.Employees;
using EducationCenter.Data.Repositories.Positions;
using EducationCenter.Data.Repositories.Students;
using EducationCenter.Data.Repositories.Subjects;
using EducationCenter.Data.Repositories.Teachers;
using EducationCenter.Data.Repositories.Users;

namespace EducationCenter.Data.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _dbContext;
    public ICourseRepository Courses { get; }
    public ICourseDetailRepository CourseDetails { get; }
    public ICourseStudentRepository CourseStudents { get; }
    public ICourseTeacherRepository CourseTeachers { get; }
    public IEmployeeRepository Employees { get; }
    public IEmployeePaymentRepository EmployeePayments { get; }
    public IPositionRepository Positions { get; }
    public IStudentRepository Students { get; }
    public IStudentPaymentRepository StudentPayments { get; }
    public ISubjectRepository Subjects { get; }
    public ITeacherRepository Teachers { get; }
    public ITeacherSubjectRepository TeacherSubjects { get; }
    public ITeacherPaymentRepository TeacherPayments { get; }
    public IUserRepository Users { get; }

    public UnitOfWork()
    {
        _dbContext = new AppDbContext();
        Courses = new CourseRepository(_dbContext);
        CourseDetails = new CourseDetailRepository(_dbContext);
        CourseStudents = new CourseStudentRepository(_dbContext);
        CourseTeachers = new CourseTeacherRepository(_dbContext);
        Employees = new EmployeeRepository(_dbContext);
        EmployeePayments = new EmployeePaymentRepository(_dbContext);
        Positions = new PositionRepository(_dbContext);
        Students = new StudentRepository(_dbContext);
        StudentPayments = new StudentPaymentRepository(_dbContext);
        Subjects = new SubjectRepository(_dbContext);
        Teachers = new TeacherRepository(_dbContext);
        TeacherPayments = new TeacherPaymentRepository(_dbContext);
        TeacherSubjects = new TeacherSubjectRepository(_dbContext);
        Users = new UserRepository(_dbContext);
    }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
