using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class Certificate : AuditableEntityWithActiveFlag
    {
        public int CertificateId { get; set; }
        public string CertificateCode { get; set; }
        public string CertificateName { get; set; }
        public int? CertificateCategoryId { get; set; }        
    }
}
