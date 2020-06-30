using System;
using System.Collections.Generic;

namespace TALMS.Domain.Entities
{
    public partial class UvTrainingsByDateSel
    {
        public int TrainingScheduleId { get; set; }
        public string CourseDescription { get; set; }
        public DateTime? TrainingDate { get; set; }
        public DateTime? TrainingTime { get; set; }
        public string EmployeeName { get; set; }
        public string RoomDescription { get; set; }
        public int? CourseId { get; set; }
        public int? TrainerId { get; set; }
        public int? RoomId { get; set; }
        public int? Pax { get; set; }
        public string CourseCode { get; set; }
    }
}
