using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class EmployeeType : AuditableEntityWithActiveFlag
    {
        public int EmployeeTypeId { get; set; }
        public string EmployeeTypeName { get; set; }
    }
}
