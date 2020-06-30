using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class EmployeeTypeConfiguration : IEntityTypeConfiguration<EmployeeType>
    {
        public void Configure(EntityTypeBuilder<EmployeeType> entity)
        {
            entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.EmployeeTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        }
    }
}