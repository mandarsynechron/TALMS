using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class TrainingSchedule : AuditableEntityWithActiveFlag
    {
        public int TrainingScheduleId { get; set; }
        public int? CourseId { get; set; }
        public DateTime? TrainingDate { get; set; }
        public DateTime? TrainingTime { get; set; }
        public int? TrainerId { get; set; }
        public int? RoomId { get; set; }
        public DateTime? TrainingEndTime { get; set; }
        public int? MasterTrainingScheduleId { get; set; }
        public string TrainingScheduleGuid { get; set; }
    }
}
