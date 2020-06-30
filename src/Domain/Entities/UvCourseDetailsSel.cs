using System;
using System.Collections.Generic;

namespace TALMS.Domain.Entities
{
    public partial class UvCourseDetailsSel
    {
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseDescription { get; set; }
        public string CourseDescriptionDetails { get; set; }
        public int? CourseLevel { get; set; }
        public int? Duration { get; set; }
        public int? ProductId { get; set; }
        public string ProductName { get; set; }
        public int? DisplayOrder { get; set; }
    }
}
