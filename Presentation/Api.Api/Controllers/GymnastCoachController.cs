using Api.Application.Features.Coachs.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GymnastCoachController : ControllerBase
    {
        private readonly IMediator mediator;
        public GymnastCoachController(IMediator mediator)
        {
            this.mediator = mediator;

        }

        [HttpGet]
        public async Task<IActionResult> GetAllGymnastCoach()
        {
            var response = await mediator.Send(new GetAllCoachQueryRequest());

            return Ok(response);
        }

    }
}
