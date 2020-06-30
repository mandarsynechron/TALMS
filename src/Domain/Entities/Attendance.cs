using TALMS.Domain.Common;

namespace TALMS.Domain.Entities
{
    public partial class Attendance : AuditableEntityWithActiveFlag
    {
        public int AttendanceId { get; set; }
        public int? TrainingScheduleId { get; set; }
        public int? EmployeeId { get; set; }
        public int? EmployeeCode { get; set; }
        public bool Present { get; set; }
        public bool Scheduled { get; set; }        
        public bool? InviteSent { get; set; }
        public bool? FeedbackRequested { get; set; }
        public bool Override { get; set; }
    }
}
