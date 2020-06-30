using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class CourseTrainer : AuditableEntityWithActiveFlag
    {
        public int TrainerId { get; set; }
        public int? EmployeeId { get; set; }
        public int? CourseId { get; set; }
    }
}
