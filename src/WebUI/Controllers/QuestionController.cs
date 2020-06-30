using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TALMS.Domain.Entities;
using TALMS.Application.Question.Commands.Create;
using TALMS.Application.Question.Commands.Update;
using TALMS.Application.Question.Commands.Delete;
using TALMS.Application.Question.Queries;

namespace TALMS.WebUI.Controllers
{
    public class QuestionController : ApiController
    {
        [HttpGet]
        public async Task<IEnumerable<Questions>> Get()
        {            
            return await Mediator.Send(new GetQuestionsQuery());
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateQuestionCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{QuestionsId}")]
        public async Task<ActionResult> Update(int QuestionsId, UpdateQuestionCommand command)
        {
            if(QuestionsId != command.QuestionsId)
                return BadRequest();

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{QuestionsId}")]
        public async Task<ActionResult> Delete(int QuestionsId)
        {
            await Mediator.Send(new DeleteQuestionCommand { QuestionsId = QuestionsId});
            return NoContent();
        }
    }
}