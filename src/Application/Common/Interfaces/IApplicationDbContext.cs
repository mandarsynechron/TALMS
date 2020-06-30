using TALMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace TALMS.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<AssetBooking> AssetBooking { get; set; }
        DbSet<Attendance> Attendance { get; set; }
        DbSet<Certificate> Certificate { get; set; }
        DbSet<CertificateCategory> CertificateCategory { get; set; }
        DbSet<CertificateEmployee> CertificateEmployee { get; set; }
        DbSet<CertificationAttendance> CertificationAttendance { get; set; }
        DbSet<CertificationMaster> CertificationMaster { get; set; }
        DbSet<Course> Course { get; set; }
        DbSet<CourseCategory> CourseCategory { get; set; }
        DbSet<CourseFileUpload> CourseFileUpload { get; set; }
        DbSet<CourseTechnology> CourseTechnology { get; set; }
        DbSet<CourseTrainer> CourseTrainer { get; set; }
        DbSet<Curriculum> Curriculum { get; set; }
        DbSet<CurriculumCourse> CurriculumCourse { get; set; }
        DbSet<DimDate> DimDate { get; set; }
        DbSet<Employee> Employee { get; set; }
        DbSet<EmployeeType> EmployeeType { get; set; }
        DbSet<FeedBack> FeedBack { get; set; }
        DbSet<FeedBackQuestion> FeedBackQuestion { get; set; }
        DbSet<FeedbackReminder> FeedbackReminder { get; set; }
        DbSet<FeedbackReminderStatus> FeedbackReminderStatus { get; set; }
        DbSet<FileUpload> FileUpload { get; set; }
        DbSet<Graduates> Graduates { get; set; }
        DbSet<Group> Group { get; set; }         
        DbSet<Location> Location { get; set; }
        DbSet<NominationStatus> NominationStatus { get; set; }
        DbSet<NominationType> NominationType { get; set; }
        DbSet<Presentation> Presentation { get; set; }
        DbSet<Product> Product { get; set; }
        DbSet<Project> Project { get; set; }
        DbSet<ProjectCurriculum> ProjectCurriculum { get; set; }
        DbSet<ProjectEmployee> ProjectEmployee { get; set; }        
        DbSet<Questions> Questions { get; set; }
        DbSet<SubGroup> SubGroup { get; set; }
        DbSet<TrainingNomination> TrainingNomination { get; set; }
        DbSet<TrainingRoom> TrainingRoom { get; set; }
        DbSet<TrainingSchedule> TrainingSchedule { get; set; }
        DbSet<UvCourseDetailsSel> UvCourseDetailsSel { get; set; }
        DbSet<UvCourseSel> UvCourseSel { get; set; }
        DbSet<UvGraduateInformation> UvGraduateInformation { get; set; }
        DbSet<UvTrainingsByDateSel> UvTrainingsByDateSel { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
