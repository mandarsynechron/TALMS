using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class FileUploadConfiguration : IEntityTypeConfiguration<FileUpload>
    {
        public void Configure(EntityTypeBuilder<FileUpload> entity)
        {
            entity.Property(e => e.FileUploadId).HasColumnName("FileUploadID");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.FileNewName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.FileOriginalName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.FileServerPath)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.FileType)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        }
    }
}