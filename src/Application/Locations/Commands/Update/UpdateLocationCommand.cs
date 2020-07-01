using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TALMS.Application.Common.Exceptions;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.Locations.Commands.Update
{
    public class UpdateLocationCommand : IRequest
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public bool ActiveFlag { get; set; }
        public string ModifiedBy { get; set; }
    }
    public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IDateTime _dateTime;

        public UpdateLocationCommandHandler(IApplicationDbContext context, IDateTime dateTime)
        {
            _context = context;
            _dateTime = dateTime;
        }
        public async Task<Unit> Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Location.FindAsync(request.LocationId);
            if(entity == null)
                throw new NotFoundException(nameof(Location), request.LocationId);
            
            entity.LocationName = request.LocationName;
            entity.ActiveFlag = request.ActiveFlag;
            entity.ModifiedBy = request.ModifiedBy;
            entity.ModifiedOn = _dateTime.Now;
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}