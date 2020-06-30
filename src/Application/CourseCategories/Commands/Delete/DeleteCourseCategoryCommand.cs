using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TALMS.Application.Common.Exceptions;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.CourseCategories.Commands.Delete
{
    public class DeleteCourseCategoriesCommand : IRequest
    {
        public int CourseCategoryId { get; set; }
    }
    public class DeleteCourseCategoryCommandHandler : IRequestHandler<DeleteCourseCategoriesCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteCourseCategoryCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteCourseCategoriesCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.CourseCategory.FindAsync(request.CourseCategoryId);
            if(entity == null)
                throw new NotFoundException(nameof(CertificateCategory), request.CourseCategoryId);            
            
            _context.CourseCategory.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}