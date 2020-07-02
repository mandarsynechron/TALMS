using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace TALMS.Application.Employees.Commands.Create
{
    public class CreateEmployeeCommand : IRequest<int>
    {
        
    }
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, int>
    {
        public Task<int> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}