using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TALMS.Application.Common.Exceptions;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.Presentations.Commands.Update
{
    public class UpdatePresentationCommand : IRequest
    {
        public int PresentationId { get; set; }
        public string DisplayText {get; set;}
	    public string DisplaySubText {get; set;}        
        public string LinkUrl { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public int? DisplayOrder { get; set; }
        public bool ActiveFlag { get; set; }
        public string ModifiedBy { get; set; }
    }
    public class UpdatePresentationCommandHandler : IRequestHandler<UpdatePresentationCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IDateTime _dateTime;

        public UpdatePresentationCommandHandler(
            IApplicationDbContext context,
            IDateTime dateTime)
        {
            _context = context;
            _dateTime = dateTime;
        }
        public async Task<Unit> Handle(UpdatePresentationCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Presentation.FindAsync(request.PresentationId);
            if(entity == null)
                throw new NotFoundException(nameof(Presentation), request.PresentationId);
                
            entity.DisplayText = request.DisplayText;
            entity.DisplaySubText = request.DisplaySubText;
            entity.LinkUrl = request.LinkUrl;
            entity.Color = request.Color;
            entity.Size = request.Size;
            entity.Type = request.Type;
            entity.DisplayOrder = request.DisplayOrder;
            entity.ActiveFlag = request.ActiveFlag;
            entity.ModifiedBy = request.ModifiedBy;
            entity.CreatedOn = _dateTime.Now;
           
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}