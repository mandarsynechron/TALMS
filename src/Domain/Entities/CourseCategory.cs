using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class CourseCategory : AuditableEntityWithActiveFlag
    {
        public int? CourseCategoryId { get; set; }
        public string CourseCategoryName { get; set; }
    }
}
