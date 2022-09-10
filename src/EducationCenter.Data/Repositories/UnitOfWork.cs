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
        AppDbContext appDbContext = new AppDbContext();
        _dbContext = appDbContext;
        Courses = new CourseRepository();
        CourseDetails = new CourseDetailRepository();
        CourseStudents = new CourseStudentRepository();
        CourseTeachers = new CourseTeacherRepository();
        Employees = new EmployeeRepository();
        EmployeePayments = new EmployeePaymentRepository();
        Positions = new PositionRepository();
        Students = new StudentRepository();
        StudentPayments = new StudentPaymentRepository();
        Subjects = new SubjectRepository();
        Teachers = new TeacherRepository();
        TeacherPayments = new TeacherPaymentRepository();
        TeacherSubjects = new TeacherSubjectRepository();
        Users = new UserRepository();
    }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
