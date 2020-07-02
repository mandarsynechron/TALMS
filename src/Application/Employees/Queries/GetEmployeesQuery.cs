using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TALMS.Domain.Entities;

namespace TALMS.Application.Employees.Queries
{
    public class GetEmployeesQuery : IRequest<IEnumerable<Employee>>
    {
        
    }
    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeesQuery, IEnumerable<Employee>>
    {
        public Task<IEnumerable<Employee>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}