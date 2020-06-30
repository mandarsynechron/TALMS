using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class CertificateCategoryConfiguration : IEntityTypeConfiguration<CertificateCategory>
    {
        public void Configure(EntityTypeBuilder<CertificateCategory> entity)
        {
            entity.Property(e => e.CertificateCategoryId).HasColumnName("CertificateCategoryID");

            entity.Property(e => e.CertificateCategoryName)
                .HasMaxLength(50)
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