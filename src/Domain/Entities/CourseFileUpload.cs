using System;
using System.Collections.Generic;

namespace TALMS.Domain.Entities
{
    public partial class CourseFileUpload
    {
        public int CourseFileUploadId { get; set; }
        public int CourseId { get; set; }
        public int FileUploadId { get; set; }
    }
}
