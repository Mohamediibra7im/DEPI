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
    }
}
