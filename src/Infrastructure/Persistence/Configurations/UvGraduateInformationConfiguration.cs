using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class UvGraduateInformationConfiguration : IEntityTypeConfiguration<UvGraduateInformation>
    {
        public void Configure(EntityTypeBuilder<UvGraduateInformation> entity)
        {
            entity.HasNoKey();

            entity.ToView("UV_GraduateInformation");

            entity.Property(e => e.CourseDescription).HasMaxLength(255);

            entity.Property(e => e.CourseId).HasColumnName("CourseID");

            entity.Property(e => e.CurriculumDesc).HasMaxLength(255);

            entity.Property(e => e.CurriculumId).HasColumnName("CurriculumID");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            entity.Property(e => e.EmployeeName).HasMaxLength(255);

            entity.Property(e => e.Graduate)
                .IsRequired()
                .HasMaxLength(10);

            entity.Property(e => e.GroupId).HasColumnName("GroupID");

            entity.Property(e => e.GroupName).HasMaxLength(255);

            entity.Property(e => e.ProjectDescription).HasMaxLength(255);

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

            entity.Property(e => e.SubGroupId).HasColumnName("SubGroupID");

            entity.Property(e => e.SubGroupName).HasMaxLength(255);
        }
    }
}