using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class Group : AuditableEntityWithActiveFlag
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
    }
}
