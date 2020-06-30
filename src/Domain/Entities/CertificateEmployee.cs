using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class CertificateEmployee : AuditableEntityWithActiveFlag
    {
        public int CertificateEmployeeId { get; set; }
        public int? CertificateId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? CertificationDate { get; set; }
    }
}
