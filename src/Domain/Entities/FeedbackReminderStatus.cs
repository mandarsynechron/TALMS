using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class FeedbackReminderStatus : AuditableEntityWithActiveFlag
    {
        public int FeedbackReminderStatusId { get; set; }
        public string FeedbackReminderStatusName { get; set; }
    }
}
