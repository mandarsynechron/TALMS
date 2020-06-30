using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class DimDateConfiguration : IEntityTypeConfiguration<DimDate>
    {
        public void Configure(EntityTypeBuilder<DimDate> entity)
        {
            entity.HasNoKey();

            entity.Property(e => e.Date).HasColumnType("date");

            entity.Property(e => e.DateKey).HasColumnName("Date_Key");

            entity.Property(e => e.EndOfMonthDate).HasColumnType("date");

            entity.Property(e => e.EndOfQuarterDate).HasColumnType("date");

            entity.Property(e => e.EndOfWeekStartingFriDate).HasColumnType("date");

            entity.Property(e => e.EndOfWeekStartingMonDate).HasColumnType("date");

            entity.Property(e => e.EndOfWeekStartingSatDate).HasColumnType("date");

            entity.Property(e => e.EndOfWeekStartingSunDate).HasColumnType("date");

            entity.Property(e => e.EndOfWeekStartingThuDate).HasColumnType("date");

            entity.Property(e => e.EndOfWeekStartingTueDate).HasColumnType("date");

            entity.Property(e => e.EndOfWeekStartingWedDate).HasColumnType("date");

            entity.Property(e => e.EndOfYearDate).HasColumnType("date");

            entity.Property(e => e.MonthName)
                .IsRequired()
                .HasMaxLength(3);

            entity.Property(e => e.MonthNameLong)
                .IsRequired()
                .HasMaxLength(9);

            entity.Property(e => e.MonthYear)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.QuarterName)
                .IsRequired()
                .HasMaxLength(2);

            entity.Property(e => e.StartOfMonthDate).HasColumnType("date");

            entity.Property(e => e.StartOfQuarterDate).HasColumnType("date");

            entity.Property(e => e.StartOfWeekStartingFriDate).HasColumnType("date");

            entity.Property(e => e.StartOfWeekStartingMonDate).HasColumnType("date");

            entity.Property(e => e.StartOfWeekStartingSatDate).HasColumnType("date");

            entity.Property(e => e.StartOfWeekStartingSunDate).HasColumnType("date");

            entity.Property(e => e.StartOfWeekStartingThuDate).HasColumnType("date");

            entity.Property(e => e.StartOfWeekStartingTueDate).HasColumnType("date");

            entity.Property(e => e.StartOfWeekStartingWedDate).HasColumnType("date");

            entity.Property(e => e.StartOfYearDate).HasColumnType("date");

            entity.Property(e => e.WeekdayName)
                .IsRequired()
                .HasMaxLength(3);

            entity.Property(e => e.WeekdayNameLong)
                .IsRequired()
                .HasMaxLength(9);

            entity.Property(e => e.YearMonthName)
                .IsRequired()
                .HasMaxLength(8);

            entity.Property(e => e.YearMonthNameLong)
                .IsRequired()
                .HasMaxLength(14);

            entity.Property(e => e.YearName)
                .IsRequired()
                .HasMaxLength(4);

            entity.Property(e => e.YearQuarterName)
                .IsRequired()
                .HasMaxLength(7);
        }
    }
}