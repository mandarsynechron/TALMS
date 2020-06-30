using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class CurriculumConfiguration : IEntityTypeConfiguration<Curriculum>
    {
        public void Configure(EntityTypeBuilder<Curriculum> entity)
        {
            entity.HasIndex(e => e.CurriculumDesc)
                .HasName("IX_UNIQUE_CurriculumDesc")
                .IsUnique();

            entity.HasIndex(e => e.SubGroupId)
                .HasName("IDX_Curriculum_SubGroupID");

            entity.Property(e => e.CurriculumId).HasColumnName("CurriculumID");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.CurriculumDesc).HasMaxLength(255);

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.SubGroupId).HasColumnName("SubGroupID");
        }
    }
}