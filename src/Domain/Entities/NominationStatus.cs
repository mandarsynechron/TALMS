using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class NominationStatus : AuditableEntityWithActiveFlag
    {
        public int NominationStatusId { get; set; }
        public string NominationStatusName { get; set; }
    }
}
