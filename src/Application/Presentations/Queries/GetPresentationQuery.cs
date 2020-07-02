using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.Presentations.Queries
{
    public class GetPresentationQuery : IRequest<IEnumerable<Presentation>>
    {       
    }
    public class GetPresentationQueryHandler : IRequestHandler<GetPresentationQuery, IEnumerable<Presentation>>
    {
        private readonly IApplicationDbContext _context;

        public GetPresentationQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Presentation>> Handle(GetPresentationQuery request, CancellationToken cancellationToken)
        {
            return await _context.Presentation.ToListAsync(cancellationToken);
        }
    }
}