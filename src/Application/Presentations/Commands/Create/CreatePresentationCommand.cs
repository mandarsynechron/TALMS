using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.Presentations.Commands.Create
{
    public class CreatePresentationCommand : IRequest<int>
    {
        public string DisplayText {get; set;}
	    public string DisplaySubText {get; set;}        
        public string LinkUrl { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public int? DisplayOrder { get; set; }
        public bool ActiveFlag { get; set; }
        public string CreatedBy { get; set; }
    }
    public class CreatePresentationCommandHandler : IRequestHandler<CreatePresentationCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IDateTime _dateTime;

        public CreatePresentationCommandHandler(IApplicationDbContext context, IDateTime dateTime)
        {
            _context = context;
            _dateTime = dateTime;
        }
        public async Task<int> Handle(CreatePresentationCommand request, CancellationToken cancellationToken)
        {
            var entity = new Presentation
            {
                DisplayText = request.DisplayText,
                DisplaySubText = request.DisplaySubText,
                LinkUrl = request.LinkUrl,
                Color = request.Color,
                Size = request.Size,
                Type = request.Type,
                DisplayOrder = request.DisplayOrder,
                ActiveFlag = request.ActiveFlag,
                CreatedBy = request.CreatedBy,
                CreatedOn = _dateTime.Now,
                ModifiedBy = request.CreatedBy,
                ModifiedOn = _dateTime.Now
            };            
            
            _context.Presentation.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.PresentationId;
        }
    }
}