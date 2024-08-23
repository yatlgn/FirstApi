using Api.Application.Features.Coachs.Command.CreateCoach;
using Api.Application.Features.Coachs.Command.DeleteCoach;
using Api.Application.Features.Coachs.Command.UpdateCoach;
using Api.Application.Features.Coachs.Queries;
using MediatR;
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
            var response = await mediator.Send(new GetAllCoachQueryRequest( ));

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> CreateAllCoach(CreateCoachCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> UpdtaeAllCoach(UpdateCoachCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> DeleteAllCoach(DeleteCoachCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }
    }
}
