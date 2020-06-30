using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class CourseTrainerConfiguration : IEntityTypeConfiguration<CourseTrainer>
    {
        public void Configure(EntityTypeBuilder<CourseTrainer> entity)
        {
            entity.HasKey(e => e.TrainerId)
                .HasName("PK_Trainer");

            entity.ToTable("Course-Trainer");

            entity.HasIndex(e => e.CourseId)
                .HasName("IDX_Course-Trainer_CourseID");

            entity.HasIndex(e => e.EmployeeId)
                .HasName("IDX_Course-Trainer_EmployeeID");

            entity.Property(e => e.TrainerId).HasColumnName("TrainerID");

            entity.Property(e => e.CourseId).HasColumnName("CourseID");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        }
    }
}