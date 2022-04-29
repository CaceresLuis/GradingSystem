using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class DataContex : DbContext
    {
        public DataContex(DbContextOptions<DataContex> options) : base(options) { }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentInscription> StudentInscriptions { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherInscription> TeacherInscriptions { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
    }
}
