using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class GraduatesConfiguration : IEntityTypeConfiguration<Graduates>
    {
        public void Configure(EntityTypeBuilder<Graduates> entity)
        {
            entity.HasKey(e => e.GraduateId);

            entity.HasIndex(e => e.CurriculumId)
                .HasName("IDX_Graduates_CurriculumID");

            entity.HasIndex(e => e.EmployeeId)
                .HasName("IDX_Graduates_EmployeeID");

            entity.HasIndex(e => new { e.EmployeeId, e.CurriculumId })
                .HasName("UNIQUE_ID_Key")
                .IsUnique();

            entity.Property(e => e.GraduateId).HasColumnName("GraduateID");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.CurriculumId).HasColumnName("CurriculumID");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            entity.Property(e => e.Graduate).HasMaxLength(10);

            entity.Property(e => e.GraduateDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

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