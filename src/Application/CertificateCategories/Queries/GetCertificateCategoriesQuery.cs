using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.CertificateCategories.Queries
{
    public class GetCertificateCategoriesQuery : IRequest<IEnumerable<CertificateCategory>>
    {
        
    }
    public class GetCertificateCategoriesQueryHandler : IRequestHandler<GetCertificateCategoriesQuery, IEnumerable<CertificateCategory>>
    {
        private readonly IApplicationDbContext _context;

        public GetCertificateCategoriesQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<CertificateCategory>> Handle(GetCertificateCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await _context.CertificateCategory.ToListAsync(cancellationToken);
        }
    }
}