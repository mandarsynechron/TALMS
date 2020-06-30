using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class Location  : AuditableEntityWithActiveFlag
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
    }
}
