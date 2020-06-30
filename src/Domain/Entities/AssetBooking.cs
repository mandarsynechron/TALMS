using System;
using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class AssetBooking : AuditableEntityWithActiveFlag
    {
        public int AssetBookingId { get; set; }
        public DateTime? BookedFromDateTime { get; set; }
        public DateTime? BookedToDateTime { get; set; }
        public string AssetType { get; set; }
        public int? AssetId { get; set; }
        public int? CourseId { get; set; }     
        public int? TrainingScheduleId { get; set; }   
    }
}
