using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TALMS.Application.Common.Exceptions;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.TrainingRooms.Commands.Update
{
    public class UpdateTrainingRoomsCommand : IRequest
    {
        public int RoomId { get; set; }
        public string RoomDescription { get; set; }

        public int SeatingCapacity { get; set; }

        public bool HasProjector { get; set; }
        public bool ActiveFlag { get; set; }

        public string ModifiedBy { get; set; }
    }

    public class UpdateTrainingRoomsCommandHandler : IRequestHandler<UpdateTrainingRoomsCommand>
    {
        private readonly IApplicationDbContext _context;
        //private readonly ICurrentUserService _userService;
        private readonly IDateTime _dateTimeService;

        public UpdateTrainingRoomsCommandHandler(
            IApplicationDbContext context,
            IDateTime dateTimeService)
        {
            _context = context;
            _dateTimeService = dateTimeService;
        }
        public async Task<Unit> Handle(UpdateTrainingRoomsCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.TrainingRoom.FindAsync(request.RoomId);
            if(entity == null)
                throw new NotFoundException(nameof(TrainingRooms), request.RoomId);
            
            entity.RoomDescription = request.RoomDescription;
            entity.SeatingCapacity = request.SeatingCapacity;
            entity.HasProjector = request.HasProjector;
            entity.ActiveFlag = request.ActiveFlag;
            entity.ModifiedBy = request.ModifiedBy;
            entity.ModifiedOn = _dateTimeService.Now;
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}