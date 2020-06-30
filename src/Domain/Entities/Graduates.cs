using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class Graduates : AuditableEntityWithActiveFlag
    {
        public int GraduateId { get; set; }
        public int EmployeeId { get; set; }
        public int? CurriculumId { get; set; }
        public string Graduate { get; set; }
        public DateTime? GraduateDate { get; set; }
    }
}
