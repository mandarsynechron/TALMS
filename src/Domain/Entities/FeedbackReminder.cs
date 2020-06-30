using System;
using System.Collections.Generic;

namespace TALMS.Domain.Entities
{
    public partial class FeedbackReminder
    {
        public long FeedbackReminderId { get; set; }
        public int? TrainingScheduleId { get; set; }
        public int? EmployeeId { get; set; }
        public int? FeedbackReminderStatusId { get; set; }
        public bool? ActiveFlag { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
        public int? FeedbackReminderCount { get; set; }
    }
}
