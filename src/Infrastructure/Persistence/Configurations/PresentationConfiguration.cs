using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class PresentationConfiguration : IEntityTypeConfiguration<Presentation>
    {
        public void Configure(EntityTypeBuilder<Presentation> entity)
        {
            entity.HasIndex(e => e.DisplayOrder)
                .HasName("IDX_Presentation_DisplayOrder");

            entity.Property(e => e.Color)
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.DisplaySubText)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DisplayText)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LinkUrl)
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedBy)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Size)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);
        }
    }
}