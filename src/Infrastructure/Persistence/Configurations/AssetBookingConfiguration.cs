using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class AssetBookingConfiguration : IEntityTypeConfiguration<AssetBooking>
    {
        public void Configure(EntityTypeBuilder<AssetBooking> builder)
        {           
            builder.HasIndex(e => new { e.TrainingScheduleId, e.AssetId })
                .HasName("IDX_AssetBookin_TrainingScheduleID_AssetID");

            builder.Property(e => e.AssetType)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.BookedFromDateTime).HasColumnType("datetime");

            builder.Property(e => e.BookedToDateTime).HasColumnType("datetime");

            builder.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            builder.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.ModifiedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            builder.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.TrainingScheduleId).HasColumnName("TrainingScheduleID");            
        }
    }
}