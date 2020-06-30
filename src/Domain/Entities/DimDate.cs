using System;
using System.Collections.Generic;

namespace TALMS.Domain.Entities
{
    public partial class DimDate
    {
        public int DateKey { get; set; }
        public DateTime Date { get; set; }
        public short Year { get; set; }
        public short YearQuarter { get; set; }
        public int YearMonth { get; set; }
        public int YearDayOfYear { get; set; }
        public byte Quarter { get; set; }
        public byte Month { get; set; }
        public short DayOfYear { get; set; }
        public byte DayOfMonth { get; set; }
        public byte DayOfWeek { get; set; }
        public string YearName { get; set; }
        public string YearQuarterName { get; set; }
        public string YearMonthName { get; set; }
        public string YearMonthNameLong { get; set; }
        public string QuarterName { get; set; }
        public string MonthName { get; set; }
        public string MonthNameLong { get; set; }
        public string WeekdayName { get; set; }
        public string WeekdayNameLong { get; set; }
        public DateTime StartOfYearDate { get; set; }
        public DateTime EndOfYearDate { get; set; }
        public DateTime StartOfQuarterDate { get; set; }
        public DateTime EndOfQuarterDate { get; set; }
        public DateTime StartOfMonthDate { get; set; }
        public DateTime EndOfMonthDate { get; set; }
        public DateTime StartOfWeekStartingSunDate { get; set; }
        public DateTime EndOfWeekStartingSunDate { get; set; }
        public DateTime StartOfWeekStartingMonDate { get; set; }
        public DateTime EndOfWeekStartingMonDate { get; set; }
        public DateTime StartOfWeekStartingTueDate { get; set; }
        public DateTime EndOfWeekStartingTueDate { get; set; }
        public DateTime StartOfWeekStartingWedDate { get; set; }
        public DateTime EndOfWeekStartingWedDate { get; set; }
        public DateTime StartOfWeekStartingThuDate { get; set; }
        public DateTime EndOfWeekStartingThuDate { get; set; }
        public DateTime StartOfWeekStartingFriDate { get; set; }
        public DateTime EndOfWeekStartingFriDate { get; set; }
        public DateTime StartOfWeekStartingSatDate { get; set; }
        public DateTime EndOfWeekStartingSatDate { get; set; }
        public int QuarterSeqNo { get; set; }
        public int MonthSeqNo { get; set; }
        public int DateSeqNo { get; set; }
        public int WeekStartingSunSeqNo { get; set; }
        public int WeekStartingMonSeqNo { get; set; }
        public int WeekStartingTueSeqNo { get; set; }
        public int WeekStartingWedSeqNo { get; set; }
        public int WeekStartingThuSeqNo { get; set; }
        public int WeekStartingFriSeqNo { get; set; }
        public int WeekStartingSatSeqNo { get; set; }
        public bool IsWeekday { get; set; }
        public string MonthYear { get; set; }
    }
}
