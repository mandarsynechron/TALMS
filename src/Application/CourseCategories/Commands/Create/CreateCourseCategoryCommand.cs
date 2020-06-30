using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.CourseCategories.Commands.Create
{
    public class CreateCourseCategoriesCommand : IRequest<int>
    {
        public string CourseCategoryName { get; set; }
        public string CreatedBy { get; set; }
    }
    public class CreateCourseCategoryCommandHandler : IRequestHandler<CreateCourseCategoriesCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IDateTime _dateTime;

        public CreateCourseCategoryCommandHandler(IApplicationDbContext context, IDateTime dateTime)
        {
            _context = context;
            _dateTime = dateTime;
        }
        public async Task<int> Handle(CreateCourseCategoriesCommand request, CancellationToken cancellationToken)
        {
            var entity = new CourseCategory
            {
                CourseCategoryName = request.CourseCategoryName,
                CreatedBy = request.CreatedBy,
                CreatedOn = _dateTime.Now
            };
            await _context.CourseCategory.AddAsync(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.CourseCategoryId.Value;
        }
    }
}