using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class TrainingNomination : AuditableEntityWithActiveFlag
    {
        public int TrainingNominationId { get; set; }
        public int? EmployeeId { get; set; }
        public int? CourseId { get; set; }
        public int? TrainingScheduleId { get; set; }
        public int? NominationTypeId { get; set; }
        public int? NominationStatusId { get; set; }
        public string RejectionReason { get; set; }
        public int? ManagerId { get; set; }
    }
}
