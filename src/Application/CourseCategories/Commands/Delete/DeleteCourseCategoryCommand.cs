using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TALMS.Application.Common.Exceptions;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.CertificateCategories.Commands.Delete
{
    public class DeleteCertificateCategoriesCommand : IRequest
    {
        public int CertificateCategoryId { get; set; }
    }
    public class DeleteCertificateCategoryCommandHandler : IRequestHandler<DeleteCertificateCategoriesCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteCertificateCategoryCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteCertificateCategoriesCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.CertificateCategory.FindAsync(request.CertificateCategoryId);
            if(entity == null)
                throw new NotFoundException(nameof(CertificateCategory), request.CertificateCategoryId);            
            
            _context.CertificateCategory.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}