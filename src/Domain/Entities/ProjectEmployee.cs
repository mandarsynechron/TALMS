using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class ProjectEmployee : AuditableEntityWithActiveFlag
    {
        public int ProjectEmployeeId { get; set; }
        public int? ProjectId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? EmployeeStartDate { get; set; }
        public DateTime? EmployeeEndDate { get; set; }
        public int? EmployeeTypeId { get; set; }
    }
}
