using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class TrainingScheduleConfiguration : IEntityTypeConfiguration<TrainingSchedule>
    {
        public void Configure(EntityTypeBuilder<TrainingSchedule> entity)
        {
            entity.HasIndex(e => e.CourseId)
                .HasName("IDX_TrainingSchedule_CourseID");

            entity.HasIndex(e => e.RoomId)
                .HasName("IDX_TrainingSchedule_RoomID");

            entity.HasIndex(e => e.TrainerId)
                .HasName("IDX_TrainingSchedule_TrainerID");

            entity.Property(e => e.TrainingScheduleId).HasColumnName("TrainingScheduleID");

            entity.Property(e => e.CourseId).HasColumnName("CourseID");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.MasterTrainingScheduleId).HasColumnName("MasterTrainingScheduleID");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.RoomId).HasColumnName("RoomID");

            entity.Property(e => e.TrainerId).HasColumnName("TrainerID");

            entity.Property(e => e.TrainingDate).HasColumnType("datetime");

            entity.Property(e => e.TrainingEndTime).HasColumnType("datetime");

            entity.Property(e => e.TrainingScheduleGuid)
                .HasColumnName("TrainingScheduleGUID")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TrainingTime).HasColumnType("datetime");
        }
    }
}