using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace TALMS.Application.Employees.Commands.Delete
{
    public class DeleteEmployeeCommand : IRequest
    {
        public int? EmployeeCode { get; set; }
    }
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand>
    {
        public Task<Unit> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}