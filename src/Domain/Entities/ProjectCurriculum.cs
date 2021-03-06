﻿using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class ProjectCurriculum : AuditableEntityWithActiveFlag
    {
        public int ProjectIcurriculmId { get; set; }
        public int? ProjectId { get; set; }
        public int? CurriculumId { get; set; }
    }
}
