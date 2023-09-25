using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

    public class DataContext:DbContext
    {
    public DataContext(DbContextOptions options) : base(options) { }

    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Attendance> Attendances { get; set; }
    public DbSet<Classrum> Classrums { get; set; }
    public DbSet<ClassrumStudent> ClassrumStudents { get; set; }
    public DbSet<Exam> Exams { get; set; }
    public DbSet<Issues> Isses { get; set; }
    public DbSet<Result> Results { get; set; }
    public DbSet<TimeTable> TimeTables { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ClassrumStudent>().HasKey(ur => new { ur.StudentId, ur.ClassrumId });

        base.OnModelCreating(modelBuilder);
    }
}


