using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class NominationType : AuditableEntityWithActiveFlag
    {
        public int NominationTypeId { get; set; }
        public string NominationTypeName { get; set; }
    }
}
