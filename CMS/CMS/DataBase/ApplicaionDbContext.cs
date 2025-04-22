using CMS.Configurations;
using CMS.Models;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data
{
    public class ApplicaionDbContext : DbContext
    {
        public ApplicaionDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EnrollmentConfiguration());

            modelBuilder.ApplyConfiguration(new FeesConfigurations());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Exams> Exams { get; set; }
        public DbSet<ExamQuestions> ExamQuestions { get; set; }
        public DbSet<Grades> Grades { get; set; }
        public DbSet<College> Collage { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Fees> Fees { get; set; }
        public DbSet<Section> Sections { get; set; }
    }
}
