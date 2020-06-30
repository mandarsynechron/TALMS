using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TALMS.Application.Common.Exceptions;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.Groups.Commands.Update
{
    public class UpdateGroupCommand : IRequest
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string ModifiedBy { get; set; }
    }

    public class UpdateGroupCommandHandler : IRequestHandler<UpdateGroupCommand>
    {
        private readonly IApplicationDbContext _context;
        //private readonly ICurrentUserService _userService;
        private readonly IDateTime _dateTimeService;

        public UpdateGroupCommandHandler(
            IApplicationDbContext context,
            IDateTime dateTimeService)
        {
            _context = context;
            _dateTimeService = dateTimeService;
        }
        public async Task<Unit> Handle(UpdateGroupCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Group.FindAsync(request.GroupId);
            if(entity == null)
                throw new NotFoundException(nameof(Group), request.GroupId);
            
            entity.GroupName = request.GroupName;
            entity.ModifiedBy = request.ModifiedBy;
            entity.ModifiedOn = _dateTimeService.Now;
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}