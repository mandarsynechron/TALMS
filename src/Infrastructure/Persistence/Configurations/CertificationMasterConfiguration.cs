using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class CertificationMasterConfiguration : IEntityTypeConfiguration<CertificationMaster>
    {
        public void Configure(EntityTypeBuilder<CertificationMaster> entity)
        {
            entity.HasNoKey();

            entity.Property(e => e.CertificationCode).HasMaxLength(255);

            entity.Property(e => e.CertificationName).HasMaxLength(255);

            entity.Property(e => e.Technology).HasMaxLength(255);
        }
    }
}