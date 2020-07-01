using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.Locations.Commands.Create
{
    public class CreateLocationCommand : IRequest<int>
    {
        public string LocationName { get; set; }
        public bool ActiveFlag { get; set; }
        public string CreatedBy { get; set; }
    }
    public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IDateTime _dataTime;

        public CreateLocationCommandHandler(IApplicationDbContext context, IDateTime dateTime)
        {
            _context = context;
            _dataTime = dateTime;
        }
        public async Task<int> Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            var entity = new Location
            {
                LocationName = request.LocationName,
                ActiveFlag = request.ActiveFlag,
                CreatedBy = request.CreatedBy,
                CreatedOn = _dataTime.Now
            };
            await _context.Location.AddAsync(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.LocationId;
        }
    }
}