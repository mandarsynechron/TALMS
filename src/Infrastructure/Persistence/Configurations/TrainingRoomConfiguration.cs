using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class TrainingRoomConfiguration : IEntityTypeConfiguration<TrainingRoom>
    {
        public void Configure(EntityTypeBuilder<TrainingRoom> entity)
        {
            entity.HasKey(e => e.RoomId);

            entity.Property(e => e.RoomId).HasColumnName("RoomID");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.RoomDescription).HasMaxLength(255);
        }
    }
}