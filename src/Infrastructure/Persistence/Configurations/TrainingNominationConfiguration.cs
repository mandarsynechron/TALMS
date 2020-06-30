using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class TrainingNominationConfiguration : IEntityTypeConfiguration<TrainingNomination>
    {
        public void Configure(EntityTypeBuilder<TrainingNomination> entity)
        {
            entity.HasIndex(e => e.CourseId)
                .HasName("IDX_TrainingNomination_CourseID");

            entity.HasIndex(e => e.EmployeeId)
                .HasName("IDX_TrainingNomination_EmployeeID");

            entity.Property(e => e.TrainingNominationId).HasColumnName("TrainingNominationID");

            entity.Property(e => e.CourseId).HasColumnName("CourseID");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.NominationStatusId).HasColumnName("NominationStatusID");

            entity.Property(e => e.NominationTypeId).HasColumnName("NominationTypeID");

            entity.Property(e => e.RejectionReason)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.TrainingScheduleId).HasColumnName("TrainingScheduleID");
        }
    }
}