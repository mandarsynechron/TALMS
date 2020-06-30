using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TALMS.Domain.Entities;
using TALMS.Application.CourseCategories.Commands.Delete;
using TALMS.Application.CourseCategories.Commands.Create;
using TALMS.Application.CourseCategories.Commands.Update;
using TALMS.Application.CourseCategories.Queries;

namespace TALMS.WebUI.Controllers
{
    public class CourseCategoryController : ApiController
    {
        [HttpGet]
        public async Task<IEnumerable<CourseCategory>> Get()
        {            
            return await Mediator.Send(new GetCourseCategoriesQuery());
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateCourseCategoriesCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{CourseCategoryId}")]
        public async Task<ActionResult> Update(int CourseCategoryId, UpdateCourseCategoriesCommand command)
        {
            if(CourseCategoryId != command.CourseCategoryId)
                return BadRequest();

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{CourseCategoryId}")]
        public async Task<ActionResult> Delete(int CourseCategoryId)
        {
            await Mediator.Send(new DeleteCourseCategoriesCommand { CourseCategoryId = CourseCategoryId});
            return NoContent();
        }
    }
}