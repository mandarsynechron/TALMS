using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class FeedbackReminderConfiguration : IEntityTypeConfiguration<FeedbackReminder>
    {
        public void Configure(EntityTypeBuilder<FeedbackReminder> entity)
        {
            entity.Property(e => e.FeedbackReminderId).HasColumnName("FeedbackReminderID");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            entity.Property(e => e.FeedbackReminderStatusId).HasColumnName("FeedbackReminderStatusID");

            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");

            entity.Property(e => e.TrainingScheduleId).HasColumnName("TrainingScheduleID");
        }
    }
}