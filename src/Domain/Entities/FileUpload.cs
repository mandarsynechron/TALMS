using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class FileUpload : AuditableEntityWithActiveFlag
    {
        public int FileUploadId { get; set; }
        public string FileOriginalName { get; set; }
        public string FileNewName { get; set; }
        public string FileServerPath { get; set; }
        public string FileType { get; set; }
    }
}
