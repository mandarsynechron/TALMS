using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class ProjectCurriculumConfiguration : IEntityTypeConfiguration<ProjectCurriculum>
    {
        public void Configure(EntityTypeBuilder<ProjectCurriculum> entity)
        {
            entity.HasKey(e => e.ProjectIcurriculmId);

            entity.ToTable("Project-Curriculum");

            entity.HasIndex(e => e.CurriculumId)
                .HasName("IDX_Project-Curriculum_CurriculumID");

            entity.HasIndex(e => e.ProjectId)
                .HasName("IDX_Project-Curriculum_ProjectID");

            entity.Property(e => e.ProjectIcurriculmId).HasColumnName("ProjectICurriculmID");

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

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
        }
    }
}