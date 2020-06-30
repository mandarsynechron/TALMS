using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;
namespace TALMS.Application.Groups.Queries
{   
    public class GetGroupQuery : IRequest<IEnumerable<Group>>
    {
    }

    public class GetGroupQueryHandler : IRequestHandler<GetGroupQuery, IEnumerable<Group>>
    {
        private readonly IApplicationDbContext _context;

        public GetGroupQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Group>> Handle(GetGroupQuery request, CancellationToken cancellationToken)
        {
            return await _context.Group.ToListAsync(cancellationToken);            
        }
    }
}