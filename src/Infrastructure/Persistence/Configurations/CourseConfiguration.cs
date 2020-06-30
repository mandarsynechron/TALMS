using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> entity)
        {
            entity.HasIndex(e => e.CourseCode)
                .HasName("IX_UNIQUE_CourseCode")
                .IsUnique();

            entity.Property(e => e.CourseId).HasColumnName("CourseID");

            entity.Property(e => e.CourseCategoryId).HasColumnName("CourseCategoryID");

            entity.Property(e => e.CourseCode).HasMaxLength(255);

            entity.Property(e => e.CourseDescription).HasMaxLength(255);

            entity.Property(e => e.CourseTechnologyId).HasColumnName("CourseTechnologyID");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.DurationType)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ProductId)
                .HasColumnName("ProductID")
                .HasDefaultValueSql("((0))");
        }
    }
}