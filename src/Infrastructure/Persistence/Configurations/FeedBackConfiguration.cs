using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class FeedBackConfiguration : IEntityTypeConfiguration<FeedBack>
    {
        public void Configure(EntityTypeBuilder<FeedBack> entity)
        {
            entity.HasIndex(e => e.EmployeeId)
                .HasName("IDX_FeedBack_EmployeeID");

            entity.HasIndex(e => e.TrainingScheduleId)
                .HasName("IDX_FeedBack_TrainingScheduleID");

            entity.HasIndex(e => new { e.EmployeeId, e.TrainingScheduleId })
                .HasName("IDX_FeedBack_EmployeeID_TrainingScheduleID");

            entity.HasIndex(e => new { e.TrainingScheduleId, e.EmployeeId })
                .HasName("IDX_FeedBack_TrainingScheduleID_EmployeeID");

            entity.Property(e => e.FeedBackId).HasColumnName("FeedBackID");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.Property(e => e.TrainingScheduleId).HasColumnName("TrainingScheduleID");
        }
    }
}