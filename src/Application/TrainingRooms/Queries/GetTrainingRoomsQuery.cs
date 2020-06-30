using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;
namespace TALMS.Application.TrainingRooms.Queries
{   
    public class GetTrainingRoomsQuery : IRequest<IEnumerable<TrainingRoom>>
    {
    }

    public class GetTrainingRoomsQueryHandler : IRequestHandler<GetTrainingRoomsQuery, IEnumerable<TrainingRoom>>
    {
        private readonly IApplicationDbContext _context;

        public GetTrainingRoomsQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TrainingRoom>> Handle(GetTrainingRoomsQuery request, CancellationToken cancellationToken)
        {
            return await _context.TrainingRoom.ToListAsync(cancellationToken);            
        }
    }
}