using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class CertificateCategory : AuditableEntityWithActiveFlag
    {
        public int CertificateCategoryId { get; set; }
        public string CertificateCategoryName { get; set; }
    }
}
