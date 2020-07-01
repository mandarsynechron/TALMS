using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TALMS.Application.Common.Exceptions;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.CertificateCategories.Commands.Update
{
    public class UpdateCertificateCategoriesCommand : IRequest
    {
        public int CertificateCategoryId { get; set; }        
        public string CertificateCategoryName { get; set; }
        public bool ActiveFlag { get; set; }
        public string ModifiedBy { get; set; }

    }

    public class UpdateCertificateCategoryCommandHandler : IRequestHandler<UpdateCertificateCategoriesCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IDateTime _dateTime;

        public UpdateCertificateCategoryCommandHandler(IApplicationDbContext context, IDateTime dateTime)
        {
            _context = context;
            _dateTime = dateTime;
        }
        public async Task<Unit> Handle(UpdateCertificateCategoriesCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.CertificateCategory.FindAsync(request.CertificateCategoryId);
            if(entity == null)
                throw new NotFoundException(nameof(CertificateCategory), request.CertificateCategoryId);
            
            entity.CertificateCategoryName = request.CertificateCategoryName;
            entity.ActiveFlag = request.ActiveFlag;
            entity.ModifiedBy = request.ModifiedBy;
            entity.ModifiedOn = _dateTime.Now;
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}