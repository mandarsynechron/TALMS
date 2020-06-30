using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> entity)
        {
            entity.HasIndex(e => e.HrmsProjectId)
                .HasName("IDX_Project_HRMS_ProjectID");

            entity.HasIndex(e => e.SubGroupId)
                .HasName("IDX_Project_SubGroupID");

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.HrmsProjectGroupId)
                .HasColumnName("HRMS_ProjectGroupID")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.HrmsProjectId).HasColumnName("HRMS_ProjectID");

            entity.Property(e => e.HrmsProjectProjectGroupId)
                .HasColumnName("HRMS_Project_ProjectGroupID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ProjectDescription).HasMaxLength(255);

            entity.Property(e => e.SubGroupId)
                .HasColumnName("SubGroupID")
                .HasDefaultValueSql("((0))");
        }
    }
}