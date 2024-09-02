using Api.Application.Features.Coachs.Queries;
using Api.Application.Features.Competitions.Command.CreateCompetition;
using Api.Application.Features.Competitions.Command.DeleteCompetition;
using Api.Application.Features.Competitions.Command.UpdateCompetition;
using Api.Application.Features.Parents.Command.CreateParent;
using Api.Application.Features.Parents.Command.DeleteParent;
using Api.Application.Features.Parents.Command.UpdateParent;
using Api.Application.Features.Parents.Queries.GetAllParent;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ParentController : ControllerBase
    {
        private readonly IMediator mediator;
        public ParentController(IMediator mediator)
        {
            this.mediator = mediator;

        }

        [HttpGet]
        public async Task<IActionResult> GetAllParent()
        {
            var response = await mediator.Send(new GetAllParentQueryRequest());

            return Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> CreateAllParent(CreateParentCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> UpdtaeAllParent(UpdateParentCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAllParent(DeleteParentCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }
    }
}
