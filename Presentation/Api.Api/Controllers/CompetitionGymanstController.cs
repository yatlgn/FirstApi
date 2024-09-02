using Api.Application.Features.Coachs.Queries;
using Api.Application.Features.CompetitionGymnasts.Command.CreateCompetitionGymnast;
using Api.Application.Features.CompetitionGymnasts.Command.DeleteCompetitionGymnast;
using Api.Application.Features.CompetitionGymnasts.Command.UpdateCompetitionGymnast;
using Api.Application.Features.CompetitionGymnasts.Queries.GetAllCompetitionGymnast;
using Api.Application.Features.Competitions.Command.CreateCompetition;
using Api.Application.Features.Competitions.Command.DeleteCompetition;
using Api.Application.Features.Competitions.Command.UpdateCompetition;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompetitionGymnastController : ControllerBase
    {
        private readonly IMediator mediator;
        public CompetitionGymnastController(IMediator mediator)
        {
            this.mediator = mediator;

        }

        [HttpGet]
        public async Task<IActionResult> GetAllCompetitionGymnast()
        {
            var response = await mediator.Send(new GetAllCompetitionGymnastQueryRequest());

            return Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> CreateAllCompetitionGymnast(CreateCompetitionGymnastCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> UpdtaeAllCompetitionGymnast(UpdateCompetitionGymnastCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAllCompetitionGymnast(DeleteCompetitionGymnastCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }
    }
}
