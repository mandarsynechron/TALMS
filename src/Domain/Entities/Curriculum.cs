using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class Curriculum : AuditableEntityWithActiveFlag
    {
        public int CurriculumId { get; set; }
        public string CurriculumDesc { get; set; }
        public int? SubGroupId { get; set; }
    }
}
