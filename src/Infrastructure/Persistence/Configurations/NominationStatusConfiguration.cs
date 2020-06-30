using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class NominationStatusConfiguration : IEntityTypeConfiguration<NominationStatus>
    {
        public void Configure(EntityTypeBuilder<NominationStatus> entity)
        {
            entity.Property(e => e.NominationStatusId).HasColumnName("NominationStatusID");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.Property(e => e.NominationStatusName)
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}