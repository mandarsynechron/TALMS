using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class Course : AuditableEntityWithActiveFlag
    {
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseDescription { get; set; }
        public string CourseDescriptionDetails { get; set; }
        public int? CourseLevel { get; set; }
        public int? Duration { get; set; }
        public int? ProductId { get; set; }       
        public int? CourseCategoryId { get; set; }
        public int? CourseTechnologyId { get; set; }
        public string DurationType { get; set; }
    }
}
