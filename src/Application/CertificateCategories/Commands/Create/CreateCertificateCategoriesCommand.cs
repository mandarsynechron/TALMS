using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.CertificateCategories.Commands.Create
{
    public class CreateCertificateCategoriesCommand : IRequest<int>
    {
        public string CertificateCategoryName { get; set; }
        public bool ActiveFlag { get; set; }
        public string CreatedBy { get; set; }
    }
    public class CreateCertificateCategoryCommandHandler : IRequestHandler<CreateCertificateCategoriesCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IDateTime _dateTime;

        public CreateCertificateCategoryCommandHandler(IApplicationDbContext context, IDateTime dateTime)
        {
            _context = context;
            _dateTime = dateTime;
        }
        public async Task<int> Handle(CreateCertificateCategoriesCommand request, CancellationToken cancellationToken)
        {
            var entity = new CertificateCategory
            {
                CertificateCategoryName = request.CertificateCategoryName,
                ActiveFlag = request.ActiveFlag,
                CreatedBy = request.CreatedBy,
                CreatedOn = _dateTime.Now
            };
            await _context.CertificateCategory.AddAsync(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.CertificateCategoryId;
        }
    }
}