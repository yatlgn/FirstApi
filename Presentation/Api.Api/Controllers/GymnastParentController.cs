using Api.Application.Features.Coachs.Queries;
using Api.Application.Features.Competitions.Command.CreateCompetition;
using Api.Application.Features.Competitions.Command.DeleteCompetition;
using Api.Application.Features.Competitions.Command.UpdateCompetition;
using Api.Application.Features.GymnastParents.Command.CreateGymnastParent;
using Api.Application.Features.GymnastParents.Command.DeleteGymnastParent;
using Api.Application.Features.GymnastParents.Command.UpdateGymnastParent;
using Api.Application.Features.GymnastParents.Queries.GetAllGymnastParent;
using Api.Application.Features.Gymnasts.Command.DeleteGymnast;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GymnastParentController : ControllerBase
    {
        private readonly IMediator mediator;
        public GymnastParentController(IMediator mediator)
        {
            this.mediator = mediator;

        }

        [HttpGet]
        public async Task<IActionResult> GetAllGymnastParent()
        {
            var response = await mediator.Send(new GetAllGymnastParentQueryRequest());

            return Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> CreateAllGymnastParent(CreateGymnastParentCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> UpdtaeAllGymnastParent(UpdateGymnastParentCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAllGymnastParent(DeleteGymnastParentCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }
    }
}
