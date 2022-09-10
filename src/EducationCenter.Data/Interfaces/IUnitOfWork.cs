using EducationCenter.Data.Interfaces.Courses;
using EducationCenter.Data.Interfaces.Employees;
using EducationCenter.Data.Interfaces.Positions;
using EducationCenter.Data.Interfaces.Students;
using EducationCenter.Data.Interfaces.Subjects;
using EducationCenter.Data.Interfaces.Teachers;
using EducationCenter.Data.Interfaces.Users;

namespace EducationCenter.Data.Interfaces;

public interface IUnitOfWork
{
    /// <summary>
    /// Courses
    /// </summary>
    ICourseRepository Courses { get; }
    ICourseDetailRepository CourseDetails { get; }
    ICourseStudentRepository CourseStudents { get; }
    ICourseTeacherRepository CourseTeachers { get; }

    /// <summary>
    /// Employees
    /// </summary>
    IEmployeeRepository Employees { get; }
    IEmployeePaymentRepository EmployeePayments { get; }

    /// <summary>
    /// Position
    /// </summary>
    IPositionRepository Positions { get; }

    /// <summary>
    /// Student
    /// </summary>
    IStudentRepository Students { get; }
    IStudentPaymentRepository StudentPayments { get; }

    /// <summary>
    /// Subject
    /// </summary>
    ISubjectRepository Subjects { get; }

    /// <summary>
    /// Teachers
    /// </summary>
    ITeacherRepository Teachers { get; }
    ITeacherSubjectRepository TeacherSubjects { get; }
    ITeacherPaymentRepository TeacherPayments { get; }

    /// <summary>
    /// Users
    /// </summary>
    IUserRepository Users { get; }

    Task SaveChangesAsync();
}
