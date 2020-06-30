using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Configuration;
using TALMS.Application.Common.Exceptions;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.TrainingRooms.Commands.Delete
{
    public class DeleteTrainingRoomsCommand : IRequest
    {
        public int RoomId { get; set; }
    }

    public class DeleteTrainingRoomsCommandHandler : IRequestHandler<DeleteTrainingRoomsCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public DeleteTrainingRoomsCommandHandler(IApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<Unit> Handle(DeleteTrainingRoomsCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.TrainingRoom.FindAsync(request.RoomId);
            if(entity == null)
                throw new NotFoundException(nameof(TrainingRooms), request.RoomId);            
            
            _context.TrainingRoom.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}