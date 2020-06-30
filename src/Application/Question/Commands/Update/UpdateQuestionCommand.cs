using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TALMS.Application.Common.Exceptions;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.Question.Commands.Update
{
    public class UpdateQuestionCommand : IRequest
    {
        public int QuestionsId { get; set; }
        public string QuestionsName { get; set; }
        public string ModifiedBy { get; set; }
    }
    public class UpdateQuestionCommandHandler : IRequestHandler<UpdateQuestionCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IDateTime _dateTimeService;

        public UpdateQuestionCommandHandler(
            IApplicationDbContext context,
            IDateTime dateTimeService)
        {
            _context = context;
            _dateTimeService = dateTimeService;
        }
        public async Task<Unit> Handle(UpdateQuestionCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Questions.FindAsync(request.QuestionsId);
            if(entity == null)
                throw new NotFoundException(nameof(Questions), request.QuestionsId);
            entity.QuestionsName = request.QuestionsName;
            entity.ModifiedBy = request.ModifiedBy;
            entity.ModifiedOn = _dateTimeService.Now;
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}