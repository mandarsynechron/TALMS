using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.TrainingRooms.Commands.Create
{
    public class CreateTrainingRoomsCommand : IRequest<int>
    {
        public string RoomDescription {get; set;}
        public int SeatingCapacity { get; set; }
        public bool HasProjector { get; set; }
        public string CreatedBy { get; set; }
    }

    public class CreateTrainingRoomsCommandHandler : IRequestHandler<CreateTrainingRoomsCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IDateTime _dateTime;
        public CreateTrainingRoomsCommandHandler(IApplicationDbContext context, IDateTime dateTime)
        {
            _context = context;            
            _dateTime = dateTime;
        }
        
        public async Task<int> Handle(CreateTrainingRoomsCommand request, CancellationToken cancellationToken)
        {
            var entity = new TrainingRoom
            {                
                RoomDescription = request.RoomDescription,
                SeatingCapacity = request.SeatingCapacity,
                HasProjector = request.HasProjector,
                CreatedBy = request.CreatedBy,
                CreatedOn = _dateTime.Now
            };            
            
            _context.TrainingRoom.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.RoomId;
        }
    }
}