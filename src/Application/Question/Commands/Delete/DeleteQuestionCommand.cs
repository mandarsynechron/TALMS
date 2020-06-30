using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Configuration;
using TALMS.Application.Common.Exceptions;
using TALMS.Application.Common.Interfaces;
using TALMS.Domain.Entities;

namespace TALMS.Application.Question.Commands.Delete
{
    public class DeleteQuestionCommand : IRequest
    {
        public int QuestionsId { get; set; }
    }

    public class DeleteQuestionCommandHandler : IRequestHandler<DeleteQuestionCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public DeleteQuestionCommandHandler(IApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<Unit> Handle(DeleteQuestionCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Questions.FindAsync(request.QuestionsId);
            if(entity == null)
                throw new NotFoundException(nameof(Questions), request.QuestionsId);            
            
            _context.Questions.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}