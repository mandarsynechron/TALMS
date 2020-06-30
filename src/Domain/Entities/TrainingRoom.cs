using System;
using System.Collections.Generic;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class TrainingRoom : AuditableEntityWithActiveFlag
    {
        public int RoomId { get; set; }
        public string RoomDescription { get; set; }
        public int? SeatingCapacity { get; set; }
        public bool HasProjector { get; set; }
    }
}
