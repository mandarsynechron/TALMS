using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Options;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Common;
using TALMS.Domain.Entities;
using TALMS.Infrastructure.Identity;

namespace TALMS.Infrastructure.Persistence
{
    public partial class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>, IApplicationDbContext
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions,
            ICurrentUserService currentUserService,
            IDateTime dateTime)
            : base(options, operationalStoreOptions)
        {
            _currentUserService = currentUserService;
            _dateTime = dateTime;
        }

        public virtual DbSet<AssetBooking> AssetBooking { get; set; }
        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<Certificate> Certificate { get; set; }
        public virtual DbSet<CertificateCategory> CertificateCategory { get; set; }
        public virtual DbSet<CertificateEmployee> CertificateEmployee { get; set; }
        public virtual DbSet<CertificationAttendance> CertificationAttendance { get; set; }
        public virtual DbSet<CertificationMaster> CertificationMaster { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<CourseCategory> CourseCategory { get; set; }
        public virtual DbSet<CourseFileUpload> CourseFileUpload { get; set; }
        public virtual DbSet<CourseTechnology> CourseTechnology { get; set; }
        public virtual DbSet<CourseTrainer> CourseTrainer { get; set; }
        public virtual DbSet<Curriculum> Curriculum { get; set; }
        public virtual DbSet<CurriculumCourse> CurriculumCourse { get; set; }
        public virtual DbSet<DimDate> DimDate { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeType> EmployeeType { get; set; }
        public virtual DbSet<FeedBack> FeedBack { get; set; }
        public virtual DbSet<FeedBackQuestion> FeedBackQuestion { get; set; }
        public virtual DbSet<FeedbackReminder> FeedbackReminder { get; set; }
        public virtual DbSet<FeedbackReminderStatus> FeedbackReminderStatus { get; set; }
        public virtual DbSet<FileUpload> FileUpload { get; set; }
        public virtual DbSet<Graduates> Graduates { get; set; }
        public virtual DbSet<Group> Group { get; set; }         
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<NominationStatus> NominationStatus { get; set; }
        public virtual DbSet<NominationType> NominationType { get; set; }
        public virtual DbSet<Presentation> Presentation { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<ProjectCurriculum> ProjectCurriculum { get; set; }
        public virtual DbSet<ProjectEmployee> ProjectEmployee { get; set; }        
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<SubGroup> SubGroup { get; set; }
        public virtual DbSet<TrainingNomination> TrainingNomination { get; set; }
        public virtual DbSet<TrainingRoom> TrainingRoom { get; set; }
        public virtual DbSet<TrainingSchedule> TrainingSchedule { get; set; }
        public virtual DbSet<UvCourseDetailsSel> UvCourseDetailsSel { get; set; }
        public virtual DbSet<UvCourseSel> UvCourseSel { get; set; }
        public virtual DbSet<UvGraduateInformation> UvGraduateInformation { get; set; }
        public virtual DbSet<UvTrainingsByDateSel> UvTrainingsByDateSel { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<IAuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.CreatedOn = _dateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = _currentUserService.UserId;
                        entry.Entity.ModifiedOn = _dateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
