using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class UvTrainingsByDateSelConfiguration : IEntityTypeConfiguration<UvTrainingsByDateSel>
    {
        public void Configure(EntityTypeBuilder<UvTrainingsByDateSel> entity)
        {
            entity.HasNoKey();

            entity.ToView("UV_TrainingsByDate_SEL");

            entity.Property(e => e.CourseCode).HasMaxLength(255);

            entity.Property(e => e.CourseDescription).HasMaxLength(255);

            entity.Property(e => e.CourseId).HasColumnName("CourseID");

            entity.Property(e => e.EmployeeName).HasMaxLength(255);

            entity.Property(e => e.RoomDescription).HasMaxLength(255);

            entity.Property(e => e.RoomId).HasColumnName("RoomID");

            entity.Property(e => e.TrainerId).HasColumnName("TrainerID");

            entity.Property(e => e.TrainingDate).HasColumnType("datetime");

            entity.Property(e => e.TrainingScheduleId).HasColumnName("TrainingScheduleID");

            entity.Property(e => e.TrainingTime).HasColumnType("datetime");
        }
    }
}