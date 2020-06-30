using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class CourseTechnologyConfiguration : IEntityTypeConfiguration<CourseTechnology>
    {
        public void Configure(EntityTypeBuilder<CourseTechnology> entity)
        {
            entity.HasNoKey();

            entity.Property(e => e.CourseTechnologyId).HasColumnName("CourseTechnologyID");

            entity.Property(e => e.CouseTechnologyDescription)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        }
    }
}