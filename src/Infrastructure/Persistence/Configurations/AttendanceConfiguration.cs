using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class AttendanceConfiguration : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> entity)
        {        
            entity.HasIndex(e => e.EmployeeId)
                .HasName("IDX_Attendance_EmployeeID");

            entity.HasIndex(e => e.TrainingScheduleId)
                .HasName("IDX_Attendance_TrainingScheduleID");

            entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            entity.Property(e => e.FeedbackRequested).HasDefaultValueSql("((0))");

            entity.Property(e => e.InviteSent).HasDefaultValueSql("((0))");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.TrainingScheduleId).HasColumnName("TrainingScheduleID");          
        }
    }
}