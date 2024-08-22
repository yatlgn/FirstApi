using Api.Application.Features.Queries.GetAllCoach;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CoachController : ControllerBase
    {
        private readonly IMediator mediator;
        public CoachController(IMediator mediator)
        {
            this.mediator = mediator;
            
        }

        [HttpGet]
        public async Task <IActionResult> GetAllCoach()
        {
            var response = await mediator.Send(new GetAllCoachQueryRequest());

            return Ok(response);
        }


    }
}
