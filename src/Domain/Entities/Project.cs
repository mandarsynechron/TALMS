using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class Project : AuditableEntityWithActiveFlag
    {
        public int ProjectId { get; set; }
        public int? HrmsProjectId { get; set; }
        public string ProjectDescription { get; set; }
        public int? SubGroupId { get; set; }
        public string HrmsProjectProjectGroupId { get; set; }
        public string HrmsProjectGroupId { get; set; }
    }
}
