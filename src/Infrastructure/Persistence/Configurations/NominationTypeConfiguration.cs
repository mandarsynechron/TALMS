using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class NominationTypeConfiguration : IEntityTypeConfiguration<NominationType>
    {
        public void Configure(EntityTypeBuilder<NominationType> entity)
        {
            entity.Property(e => e.NominationTypeId).HasColumnName("NominationTypeID");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.Property(e => e.NominationTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}