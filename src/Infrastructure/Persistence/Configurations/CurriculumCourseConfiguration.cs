using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class CurriculumCourseConfiguration : IEntityTypeConfiguration<CurriculumCourse>
    {
        public void Configure(EntityTypeBuilder<CurriculumCourse> entity)
        {
            entity.ToTable("Curriculum-Course");

            entity.HasIndex(e => e.CourseId)
                .HasName("IDX_Curriculum-Course_CourseID");

            entity.HasIndex(e => e.CurriculumId)
                .HasName("IDX_Curriculum-Course_CurriculumID");

            entity.Property(e => e.CurriculumCourseId).HasColumnName("CurriculumCourseID");

            entity.Property(e => e.CourseId).HasColumnName("CourseID");

            entity.Property(e => e.CourseType).HasMaxLength(255);

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.CurriculumId).HasColumnName("CurriculumID");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        }
    }
}