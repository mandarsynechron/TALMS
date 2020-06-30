using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class CertificateConfiguration : IEntityTypeConfiguration<Certificate>
    {
        public void Configure(EntityTypeBuilder<Certificate> entity)
        {            
            entity.Property(e => e.CertificateId).HasColumnName("CertificateID");

            entity.Property(e => e.CertificateCategoryId).HasColumnName("CertificateCategoryID");

            entity.Property(e => e.CertificateCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CertificateName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");            
        }
    }
}