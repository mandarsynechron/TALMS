using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class CourseCategoryConfiguration : IEntityTypeConfiguration<CourseCategory>
    {
        public void Configure(EntityTypeBuilder<CourseCategory> entity)
        {
            entity.HasNoKey();

            entity.Property(e => e.CourseCategoryId).HasColumnName("CourseCategoryID");

            entity.Property(e => e.CourseCategoryName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        }
    }
}