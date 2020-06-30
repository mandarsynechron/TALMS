using System;
namespace TALMS.Domain.Common
{
    public abstract class AuditableEntityWithActiveFlag : IAuditableEntity
    {
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }        
        public bool? ActiveFlag { get; set; }
    }
}