using System;
using System.Collections.Generic;

namespace TALMS.Domain.Entities
{
    public partial class CertificationAttendance
    {
        public double? EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string ProjectGroup { get; set; }
        public string CertificationName { get; set; }
        public string CertificationCode { get; set; }
        public string AccountatCertification { get; set; }
        public string CurrentAccount { get; set; }
        public DateTime? AttendDate { get; set; }
    }
}
