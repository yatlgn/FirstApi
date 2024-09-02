
using Api.Application.Features.CoachGymnasts.Command.CreateCoachGymanst;
using Api.Application.Features.CoachGymnasts.Command.DeleteCoachGymnast;
using Api.Application.Features.CoachGymnasts.Command.UpdateCoachGymnast;
using Api.Application.Features.CoachGymnasts.Queries.GetAllCoachGymnast;
using Api.Application.Features.Coachs.Command.CreateCoach;
using Api.Application.Features.Coachs.Command.DeleteCoach;
using Api.Application.Features.Coachs.Command.UpdateCoach;
using Api.Application.Features.Coachs.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CoachGymnastController : ControllerBase
    {
        private readonly IMediator mediator;
        public CoachGymnastController(IMediator mediator)
        {
            this.mediator = mediator;

        }

        [HttpGet]
       
        public async Task<IActionResult> GetAllCoachGymnast()
        {
            var response = await mediator.Send(new GetAllCoachGymnastQueryRequest());

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAllCoachGymnast(CreateCoachGymnastCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> UpdtaeAllCoachGymnast(UpdateCoachGymnastCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAllCoachGymnast(DeleteCoachGymnastCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }
    }
}
