using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class UvCourseSelConfiguration : IEntityTypeConfiguration<UvCourseSel>
    {
        public void Configure(EntityTypeBuilder<UvCourseSel> entity)
        {
            entity.HasNoKey();

            entity.ToView("UV_Course_SEL");

            entity.Property(e => e.CourseDescription).HasMaxLength(255);

            entity.Property(e => e.CourseId)
                .HasColumnName("CourseID")
                .ValueGeneratedOnAdd();
        }
    }
}