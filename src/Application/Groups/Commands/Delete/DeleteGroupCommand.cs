using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Configuration;
using TALMS.Application.Common.Exceptions;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.Groups.Commands.Delete
{
    public class DeleteGroupCommand : IRequest
    {
        public int GroupId { get; set; }
    }

    public class DeleteGroupCommandHandler : IRequestHandler<DeleteGroupCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public DeleteGroupCommandHandler(IApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<Unit> Handle(DeleteGroupCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Group.FindAsync(request.GroupId);
            if(entity == null)
                throw new NotFoundException(nameof(Group), request.GroupId);            
            
            _context.Group.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}