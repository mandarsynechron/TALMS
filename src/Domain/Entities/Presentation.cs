using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class Presentation : AuditableEntityWithActiveFlag
    {
        public int PresentationId { get; set; }
        public string DisplayText { get; set; }
        public string DisplaySubText { get; set; }
        public string LinkUrl { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public int? DisplayOrder { get; set; }
    }
}
