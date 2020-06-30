using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class CourseFileUploadConfiguration : IEntityTypeConfiguration<CourseFileUpload>
    {
        public void Configure(EntityTypeBuilder<CourseFileUpload> entity)
        {
            entity.ToTable("Course-FileUpload");

            entity.HasIndex(e => new { e.CourseId, e.FileUploadId })
                .HasName("IDX_Course-FileUpload_CourseID_FileUPloadID");

            entity.Property(e => e.CourseFileUploadId).HasColumnName("CourseFileUploadID");

            entity.Property(e => e.CourseId).HasColumnName("CourseID");

            entity.Property(e => e.FileUploadId).HasColumnName("FileUploadID");
        }
    }
}