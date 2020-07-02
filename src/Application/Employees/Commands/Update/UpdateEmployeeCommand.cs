using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace TALMS.Application.Employees.Commands.Update
{
    public class UpdateEmployeeCommand : IRequest
    {
        public int EmployeeId { get; set; }
        public int? EmployeeCode { get; set; }
    }
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand>
    {
        public Task<Unit> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}