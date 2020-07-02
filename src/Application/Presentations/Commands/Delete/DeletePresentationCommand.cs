using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Configuration;
using TALMS.Application.Common.Exceptions;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.Presentations.Commands.Delete
{
    public class DeletePresentationCommand : IRequest
    {
        public int PresentationId { get; set; }
    }

    public class DeleteGroupCommandHandler : IRequestHandler<DeletePresentationCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public DeleteGroupCommandHandler(IApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<Unit> Handle(DeletePresentationCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Presentation.FindAsync(request.PresentationId);
            if(entity == null)
                throw new NotFoundException(nameof(Presentation), request.PresentationId);            
            
            _context.Presentation.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}