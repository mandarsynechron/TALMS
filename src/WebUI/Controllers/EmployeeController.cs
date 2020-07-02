using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TALMS.Application.Employees.Commands.Create;
using TALMS.Application.Employees.Commands.Delete;
using TALMS.Application.Employees.Commands.Update;
using TALMS.Application.Employees.Queries;
using TALMS.Domain.Entities;

namespace TALMS.WebUI.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {            
            return await Mediator.Send(new GetEmployeesQuery());
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateEmployeeCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{EmployeeCode}")]
        public async Task<ActionResult> Update(int EmployeeCode, UpdateEmployeeCommand command)
        {
            if(EmployeeCode != command.EmployeeCode)
                return BadRequest();

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{EmployeeCode}")]
        public async Task<ActionResult> Delete(int EmployeeCode)
        {
            await Mediator.Send(new DeleteEmployeeCommand { EmployeeCode = EmployeeCode});
            return NoContent();
        }
    }
}