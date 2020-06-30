using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TALMS.Application.Common.Exceptions;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.CourseCategories.Commands.Update
{
    public class UpdateCourseCategoriesCommand : IRequest
    {
        public int CourseCategoryId { get; set; }
        public string CourseCategoryName { get; set; }
        public string ModifiedBy { get; set; }

    }

    public class UpdateCourseCategoryCommandHandler : IRequestHandler<UpdateCourseCategoriesCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IDateTime _dateTime;

        public UpdateCourseCategoryCommandHandler(IApplicationDbContext context, IDateTime dateTime)
        {
            _context = context;
            _dateTime = dateTime;
        }
        public async Task<Unit> Handle(UpdateCourseCategoriesCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.CourseCategory.FindAsync(request.CourseCategoryId);
            if(entity == null)
                throw new NotFoundException(nameof(CertificateCategory), request.CourseCategoryId);
            
            entity.CourseCategoryName = request.CourseCategoryName;
            entity.ModifiedBy = request.ModifiedBy;
            entity.ModifiedOn = _dateTime.Now;
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}