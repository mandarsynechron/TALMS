using System;
using System.Collections.Generic;

namespace TALMS.Domain.Entities
{
    public partial class UvGraduateInformation
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int SubGroupId { get; set; }
        public string SubGroupName { get; set; }
        public int ProjectId { get; set; }
        public string ProjectDescription { get; set; }
        public int CurriculumId { get; set; }
        public string CurriculumDesc { get; set; }
        public int CourseId { get; set; }
        public string CourseDescription { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Graduate { get; set; }
        public int? CourseCount { get; set; }
    }
}
