using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class SubGroup : AuditableEntityWithActiveFlag
    {
        public int SubGroupId { get; set; }
        public int? GroupId { get; set; }
        public string SubGroupName { get; set; }
        public int? HrmsProjectId { get; set; }
    }
}
