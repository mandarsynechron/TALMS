using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Configuration;
using TALMS.Application.Common.Exceptions;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.Locations.Commands.Delete
{
    public class DeleteLocationCommand : IRequest
    {
        public int LocationId { get; set; }
    }
    public class DeleteLocationCommandHandler : IRequestHandler<DeleteLocationCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public DeleteLocationCommandHandler(IApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<Unit> Handle(DeleteLocationCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Location.FindAsync(request.LocationId);
            if(entity == null)
                throw new NotFoundException(nameof(Location), request.LocationId);            
            
            _context.Location.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}