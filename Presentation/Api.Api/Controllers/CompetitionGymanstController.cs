using Api.Application.Features.Coachs.Queries;
using Api.Application.Features.CompetitionGymnasts.Queries.GetAllCompetitionGymnast;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Api.Controllers
{
    [Route("api/[controller]")]
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
    }
}
