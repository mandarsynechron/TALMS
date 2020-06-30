using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class CertificateEmployeeConfiguration : IEntityTypeConfiguration<CertificateEmployee>
    {
        public void Configure(EntityTypeBuilder<CertificateEmployee> entity)
        {
            entity.Property(e => e.CertificateEmployeeId).HasColumnName("CertificateEmployeeID");

            entity.Property(e => e.CertificateId).HasColumnName("CertificateID");

            entity.Property(e => e.CertificationDate).HasColumnType("datetime");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        }
    }
}