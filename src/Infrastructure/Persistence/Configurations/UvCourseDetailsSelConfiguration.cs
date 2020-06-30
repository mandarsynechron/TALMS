using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class UvCourseDetailsSelConfiguration : IEntityTypeConfiguration<UvCourseDetailsSel>
    {
        public void Configure(EntityTypeBuilder<UvCourseDetailsSel> entity)
        {
            entity.HasNoKey();

            entity.ToView("UV_CourseDetails_SEL");

            entity.Property(e => e.CourseCode).HasMaxLength(255);

            entity.Property(e => e.CourseDescription).HasMaxLength(255);

            entity.Property(e => e.CourseId).HasColumnName("CourseID");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.Property(e => e.ProductName).HasMaxLength(200);
        }
    }
}