using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TALMS.Application.Presentations.Commands.Create;
using TALMS.Application.Presentations.Commands.Delete;
using TALMS.Application.Presentations.Commands.Update;
using TALMS.Application.Presentations.Queries;
using TALMS.Domain.Entities;

namespace TALMS.WebUI.Controllers
{
    public class PresentationController : ApiController
    {
        [HttpGet]
        public async Task<IEnumerable<Presentation>> Get()
        {            
            return await Mediator.Send(new GetPresentationQuery());
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreatePresentationCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{PresentationId}")]
        public async Task<ActionResult> Update(int PresentationId, UpdatePresentationCommand command)
        {
            if(PresentationId != command.PresentationId)
                return BadRequest();

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{PresentationId}")]
        public async Task<ActionResult> Delete(int GroupId)
        {
            await Mediator.Send(new DeletePresentationCommand { PresentationId = GroupId});
            return NoContent();
        }
    }
}