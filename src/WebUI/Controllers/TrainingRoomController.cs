using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TALMS.Application.TrainingRooms.Commands.Create;
using TALMS.Application.TrainingRooms.Commands.Update;
using TALMS.Application.TrainingRooms.Commands.Delete;
using TALMS.Application.TrainingRooms.Queries;
using TALMS.Domain.Entities;

namespace TALMS.WebUI.Controllers
{
    public class TrainingRoomController : ApiController
    {
        [HttpGet]
        public async Task<IEnumerable<TrainingRoom>> Get()
        {            
            return await Mediator.Send(new GetTrainingRoomsQuery());
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateTrainingRoomsCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{RoomId}")]
        public async Task<ActionResult> Update(int RoomId, UpdateTrainingRoomsCommand command)
        {
            if(RoomId != command.RoomId)
                return BadRequest();

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{RoomId}")]
        public async Task<ActionResult> Delete(int RoomId)
        {
            await Mediator.Send(new DeleteTrainingRoomsCommand { RoomId = RoomId});
            return NoContent();
        }
    }
}