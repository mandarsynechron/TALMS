using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.Groups.Commands.Create
{
    public class CreateGroupCommand : IRequest<int>
    {
        public string GroupName {get; set;}
        public string CreatedBy { get; set; }
    }

    public class CreateGroupCommandHandler : IRequestHandler<CreateGroupCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IDateTime _dateTime;
        public CreateGroupCommandHandler(IApplicationDbContext context, IDateTime dateTime)
        {
            _context = context;            
            _dateTime = dateTime;
        }
        
        public async Task<int> Handle(CreateGroupCommand request, CancellationToken cancellationToken)
        {
            var entity = new Group
            {
                GroupName = request.GroupName,
                CreatedBy = request.CreatedBy,
                CreatedOn = _dateTime.Now
            };            
            
            _context.Group.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.GroupId;
        }
    }
}