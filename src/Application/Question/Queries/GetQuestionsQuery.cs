using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.Question.Queries
{
    public class GetQuestionsQuery : IRequest<IEnumerable<Questions>>
    {
        
    }
    public class GetQuestionsQueryHandler : IRequestHandler<GetQuestionsQuery, IEnumerable<Questions>>
    {
        private readonly IApplicationDbContext _context;

        public GetQuestionsQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Questions>> Handle(GetQuestionsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Questions.ToListAsync(cancellationToken);
        }
    }
}