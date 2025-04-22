using CMS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Configurations
{
    internal class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.Property(a => a.Semester)
                .IsRequired();

            builder.Property(a => a.CreationDate)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()")
                .HasColumnType("Date"); // this is date only from db
        }
    }
}