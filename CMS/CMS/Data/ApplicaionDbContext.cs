using CMS.Models;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data
{
    public class ApplicaionDbContext : DbContext
    {
        public ApplicaionDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Students> Students { get; set; }
        public DbSet<Exams> Exams { get; set; }
        public DbSet<ExamQuestions> ExamQuestions { get; set; }
        public DbSet<Grades> Grades { get; set; }
    }
}
