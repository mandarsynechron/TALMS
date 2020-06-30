using System;

namespace TALMS.Domain.Common
{
    public class AuditableEntity : IAuditableEntity
    {
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}