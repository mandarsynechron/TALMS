using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> entity)
        {
            entity.HasIndex(e => e.EmployeeCode)
                .HasName("IX_UNIQUE_EmployeeCode")
                .IsUnique();

            entity.HasIndex(e => e.LocationId)
                .HasName("IDX_Employee_LocationID");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            entity.Property(e => e.AccountAllocationDate).HasColumnType("datetime");

            entity.Property(e => e.AccountReleaseDate).HasColumnType("datetime");

            entity.Property(e => e.ClientId).HasColumnName("ClientID");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.EmployeeEmailAddress).HasMaxLength(255);

            entity.Property(e => e.EmployeeName).HasMaxLength(255);

            entity.Property(e => e.LocationId).HasColumnName("LocationID");

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