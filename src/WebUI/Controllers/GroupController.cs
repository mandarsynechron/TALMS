using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TALMS.Domain.Entities;
using TALMS.Application.Groups.Queries;
using TALMS.Application.Groups.Commands.Create;
using TALMS.Application.Groups.Commands.Update;
using TALMS.Application.Groups.Commands.Delete;
using System.Collections.Generic;

namespace TALMS.WebUI.Controllers
{    
    public class GroupController : ApiController
    {
        [HttpGet]
        public async Task<IEnumerable<Group>> Get()
        {            
            return await Mediator.Send(new GetGroupQuery());
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateGroupCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{GroupId}")]
        public async Task<ActionResult> Update(int GroupId, UpdateGroupCommand command)
        {
            if(GroupId != command.GroupId)
                return BadRequest();

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{GroupId}")]
        public async Task<ActionResult> Delete(int GroupId)
        {
            await Mediator.Send(new DeleteGroupCommand { GroupId = GroupId});
            return NoContent();
        }
    }
}