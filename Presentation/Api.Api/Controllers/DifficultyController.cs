using Api.Application.Features.Coachs.Queries;
using Api.Application.Features.CompetitionGymnasts.Command.DeleteCompetitionGymnast;
using Api.Application.Features.CompetitionGymnasts.Command.UpdateCompetitionGymnast;
using Api.Application.Features.Competitions.Command.CreateCompetition;
using Api.Application.Features.Competitions.Command.DeleteCompetition;
using Api.Application.Features.Competitions.Command.UpdateCompetition;
using Api.Application.Features.Difficulties.Command.CreateDifficulty;
using Api.Application.Features.Difficulties.Command.DeleteDifficulty;
using Api.Application.Features.Difficulties.Command.UpdateDifficulty;
using Api.Application.Features.Difficulties.Queries.GetAllDifficulty;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DifficultyController : ControllerBase
    {
        private readonly IMediator mediator;
        public DifficultyController(IMediator mediator)
        {
            this.mediator = mediator;

        }

        [HttpGet]
        public async Task<IActionResult> GetAllDifficulty()
        {
            var response = await mediator.Send(new GetAllDifficultyQueryRequest());

            return Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> CreateAllDifficulty(CreateDifficultyCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> UpdtaeAllDifficulty(UpdateDifficultyCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAllDifficulty(DeleteDifficultyCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }
    }
}
