using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class CurriculumCourse : AuditableEntityWithActiveFlag
    {
        public int CurriculumCourseId { get; set; }
        public int? CurriculumId { get; set; }
        public int? CourseId { get; set; }
        public string CourseType { get; set; }
    }
}
