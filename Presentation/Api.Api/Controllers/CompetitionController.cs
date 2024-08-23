using Api.Application.Features.Coachs.Queries;
using Api.Application.Features.Competitions.Queries.GetAllCompetition;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Api.Controllers
{
    [Route("api/[controller]")]
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
    }
}
