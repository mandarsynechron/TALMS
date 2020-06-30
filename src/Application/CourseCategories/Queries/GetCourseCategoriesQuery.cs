using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.CourseCategories.Queries
{
    public class GetCourseCategoriesQuery : IRequest<IEnumerable<CourseCategory>>
    {
        
    }
    public class GetCourseCategoriesQueryHandler : IRequestHandler<GetCourseCategoriesQuery, IEnumerable<CourseCategory>>
    {
        private readonly IApplicationDbContext _context;

        public GetCourseCategoriesQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<CourseCategory>> Handle(GetCourseCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await _context.CourseCategory.ToListAsync(cancellationToken);
        }
    }
}