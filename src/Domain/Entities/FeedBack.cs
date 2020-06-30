using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class FeedBack : AuditableEntity
    {
        public int FeedBackId { get; set; }
        public int? TrainingScheduleId { get; set; }
        public int? EmployeeId { get; set; }
        public string CommentDescription { get; set; }
    }
}
