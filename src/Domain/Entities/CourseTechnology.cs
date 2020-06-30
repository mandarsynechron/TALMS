using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class CourseTechnology : AuditableEntityWithActiveFlag
    {
        public int? CourseTechnologyId { get; set; }
        public string CouseTechnologyDescription { get; set; }
    }
}
