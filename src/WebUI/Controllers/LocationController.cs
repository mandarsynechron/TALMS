using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TALMS.Application.Locations.Commands.Create;
using TALMS.Application.Locations.Commands.Update;
using TALMS.Application.Locations.Commands.Delete;
using TALMS.Application.Locations.Queries;
using TALMS.Domain.Entities;

namespace TALMS.WebUI.Controllers
{
    public class LocationController : ApiController
    {
        [HttpGet]
        public async Task<IEnumerable<Location>> Get()
        {            
            return await Mediator.Send(new GetLocationsQuery());
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateLocationCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{LocationId}")]
        public async Task<ActionResult> Update(int LocationId, UpdateLocationCommand command)
        {
            if(LocationId != command.LocationId)
                return BadRequest();

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{LocationId}")]
        public async Task<ActionResult> Delete(int GroupId)
        {
            await Mediator.Send(new DeleteLocationCommand { LocationId = GroupId});
            return NoContent();
        }
    }
}