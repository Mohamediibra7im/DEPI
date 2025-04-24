using CMS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Configurations
{
    internal class SectionConfigurations : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.HasKey(f => f.SectionId);

            builder.Property(a => a.RoomNumber)
                .IsRequired();

            builder.Property(a => a.MeetingTime)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");

            builder.Property(a => a.SectionNum)
                .IsRequired();

            builder.Property(a => a.Capacity)
                .IsRequired();

            builder.Property(a => a.Semester)
                .IsRequired();

            builder.Property(a => a.TAName)
                .IsRequired();
        }
    }
}
