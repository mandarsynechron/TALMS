using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class Employee : AuditableEntityWithActiveFlag
    {
        public int EmployeeId { get; set; }
        public int? EmployeeCode { get; set; }
        public int? ClientId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmailAddress { get; set; }
        public DateTime? AccountAllocationDate { get; set; }
        public DateTime? AccountReleaseDate { get; set; }
        public int? LocationId { get; set; }
        public bool? IsAdmin { get; set; }
    }
}
