using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TALMS.Application.CertificateCategories.Commands.Create;
using TALMS.Application.CertificateCategories.Commands.Delete;
using TALMS.Application.CertificateCategories.Commands.Update;
using TALMS.Application.CertificateCategories.Queries;
using TALMS.Domain.Entities;

namespace TALMS.WebUI.Controllers
{
    public class CertificateCategoryController : ApiController
    {
         [HttpGet]
        public async Task<IEnumerable<CertificateCategory>> Get()
        {            
            return await Mediator.Send(new GetCertificateCategoriesQuery());
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateCertificateCategoriesCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{CertificateCategoryId}")]
        public async Task<ActionResult> Update(int CertificateCategoryId, UpdateCertificateCategoriesCommand command)
        {
            if(CertificateCategoryId != command.CertificateCategoryId)
                return BadRequest();

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{CertificateCategoryId}")]
        public async Task<ActionResult> Delete(int CertificateCategoryId)
        {
            await Mediator.Send(new DeleteCertificateCategoriesCommand { CertificateCategoryId = CertificateCategoryId});
            return NoContent();
        }
    }
}