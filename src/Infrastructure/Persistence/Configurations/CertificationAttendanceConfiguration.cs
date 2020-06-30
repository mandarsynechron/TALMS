using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class CertificationAttendanceConfiguration : IEntityTypeConfiguration<CertificationAttendance>
    {
        public void Configure(EntityTypeBuilder<CertificationAttendance> entity)
        {
            entity.HasNoKey();

            entity.Property(e => e.AccountatCertification).HasMaxLength(255);

            entity.Property(e => e.AttendDate).HasColumnType("datetime");

            entity.Property(e => e.CertificationCode).HasMaxLength(255);

            entity.Property(e => e.CertificationName).HasMaxLength(255);

            entity.Property(e => e.CurrentAccount).HasMaxLength(255);

            entity.Property(e => e.Department).HasMaxLength(255);

            entity.Property(e => e.Designation).HasMaxLength(255);

            entity.Property(e => e.EmployeeName).HasMaxLength(255);

            entity.Property(e => e.ProjectGroup).HasMaxLength(255);
        }
    }
}