using Api.Application.Features.CoachGymnasts.Command.CreateCoachGymanst;
using Api.Application.Features.Coachs.Command.DeleteCoach;
using Api.Application.Features.Coachs.Command.UpdateCoach;
using Api.Application.Features.Coachs.Queries;
using Api.Application.Features.Competitions.Command.CreateCompetition;
using Api.Application.Features.Competitions.Command.DeleteCompetition;
using Api.Application.Features.Competitions.Command.UpdateCompetition;
using Api.Application.Features.Competitions.Queries.GetAllCompetition;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompetitionController : ControllerBase
    {
        private readonly IMediator mediator;
        public CompetitionController(IMediator mediator)
        {
            this.mediator = mediator;

        }

        [HttpGet]
        public async Task<IActionResult> GetAllCompetition()
        {
            var response = await mediator.Send(new GetAllCompetitionQueryRequest());

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAllCompetition(CreateCompetitionCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> UpdtaeAllCompetition(UpdateCompetitionCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAllCompetition(DeleteCompetitionCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }
    }
}
