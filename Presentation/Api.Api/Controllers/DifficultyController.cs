using Api.Application.Features.Coachs.Queries;
using Api.Application.Features.Difficulties.Queries.GetAllDifficulty;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Api.Controllers
{
    [Route("api/[controller]")]
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
    }
}
