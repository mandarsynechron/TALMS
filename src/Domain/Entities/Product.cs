using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class Product  : AuditableEntityWithActiveFlag
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
