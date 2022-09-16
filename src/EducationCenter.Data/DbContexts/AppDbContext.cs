using EducationCenter.Domain.Constants;
using EducationCenter.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EducationCenter.Data.DbContexts;

public class AppDbContext : DbContext
{
    public virtual DbSet<Course> Courses { get; set; } = null!;

    public virtual DbSet<CourseDetail> CourseDetails { get; set; } = null!;

    public virtual DbSet<CourseStudent> CourseStudents { get; set; } = null!;

    public virtual DbSet<CourseTeacher> CourseTeachers { get; set; } = null!;

    public virtual DbSet<Employee> Employees { get; set; } = null!;

    public virtual DbSet<EmployeePayment> EmployeePayments { get; set; } = null!;

    public virtual DbSet<Position> Positions { get; set; } = null!;

    public virtual DbSet<Student> Students { get; set; } = null!;

    public virtual DbSet<StudentPayment> StudentPayments { get; set; } = null!;

    public virtual DbSet<Subject> Subjects { get; set; } = null!;

    public virtual DbSet<Teacher> Teachers { get; set; } = null!;

    public virtual DbSet<TeacherPayment> TeacherPayments { get; set; } = null!;

    public virtual DbSet<TeacherSubject> TeacherSubjects { get; set; } = null!;

    public virtual DbSet<User> Users { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(DbConstants.CONNECTION_STRING);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();
    }
}
