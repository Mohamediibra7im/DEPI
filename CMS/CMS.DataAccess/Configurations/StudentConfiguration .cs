using CMS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace CMS.Configurations
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Students>
    {
        public void Configure(EntityTypeBuilder<Students> builder)
        {
            builder.Property(s => s.GPA)
         .IsRequired()
         .HasDefaultValue(4.0m)
           .HasColumnType("decimal(3,2)");

            builder.Property(s => s.Address)
            .IsRequired();




            builder.Property(s => s.FirstName)
           .IsRequired();

            builder.Property(s => s.LastName)
           .IsRequired();


            builder.Property(s => s.EnrollmentDate)
         .HasDefaultValueSql("GETDATE()");

            


        }
    }
}