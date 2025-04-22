using CMS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Configurations
{
    internal class FeesConfigurations : IEntityTypeConfiguration<Fees>
    {
        public void Configure(EntityTypeBuilder<Fees> builder)
        {
            builder.HasKey(f => f.FeeId); // PK

            builder.Property(a => a.Amount)
                .IsRequired();

            builder.Property(a => a.DueDate)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");

            builder.Property(a => a.Status)
                .IsRequired()
                .HasMaxLength(10);
        }
    }
}