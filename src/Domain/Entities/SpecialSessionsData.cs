using System;
using System.Collections.Generic;

namespace TALMS.Domain.Entities
{
    public partial class SpecialSessionsData
    {
        public string Course { get; set; }
        public string CourseCode { get; set; }
        public DateTime? TrainingDate { get; set; }
        public string Time { get; set; }
        public string Time2 { get; set; }
        public DateTime? StartTime { get; set; }
        public string TrainingRoom { get; set; }
        public double? TrainingRoomId { get; set; }
        public string Trainer { get; set; }
        public double? TrainerId { get; set; }
        public double? Participants { get; set; }
        public int? CourseId { get; set; }
        public int? ScheduleId { get; set; }
    }
}
