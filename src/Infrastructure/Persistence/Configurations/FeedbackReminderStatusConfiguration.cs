using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class FeedbackReminderStatusConfiguration : IEntityTypeConfiguration<FeedbackReminderStatus>
    {
        public void Configure(EntityTypeBuilder<FeedbackReminderStatus> entity)
        {
            entity.Property(e => e.FeedbackReminderStatusId).HasColumnName("FeedbackReminderStatusID");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.FeedbackReminderStatusName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        }
    }
}