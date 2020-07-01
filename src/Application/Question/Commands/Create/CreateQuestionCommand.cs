using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.Question.Commands.Create
{
    public class CreateQuestionCommand : IRequest<int>
    {
        public string QuestionsName { get; set; }
        public bool ActiveFlag { get; set; }
        public string CreatedBy { get; set; }
    }
    public class CreateQuestionCommandHandler : IRequestHandler<CreateQuestionCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IDateTime _dateTime;

        public CreateQuestionCommandHandler(IApplicationDbContext context, IDateTime dateTime)
        {
            _context = context;
            _dateTime = dateTime;
        }
        public async Task<int> Handle(CreateQuestionCommand request, CancellationToken cancellationToken)
        {
            var entity = new Questions
            {
                QuestionsName = request.QuestionsName,
                ActiveFlag = request.ActiveFlag,
                CreatedBy = request.CreatedBy,
                CreatedOn = _dateTime.Now
            };

            _context.Questions.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.QuestionsId;
        }
    }
}