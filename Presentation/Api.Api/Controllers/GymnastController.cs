using Api.Application.Features.Coachs.Queries;
using Api.Application.Features.Competitions.Command.CreateCompetition;
using Api.Application.Features.Competitions.Command.DeleteCompetition;
using Api.Application.Features.Competitions.Command.UpdateCompetition;
using Api.Application.Features.Gymnasts.Command.CreateGymnast;
using Api.Application.Features.Gymnasts.Command.DeleteGymnast;
using Api.Application.Features.Gymnasts.Command.UpdateGymnast;
using Api.Application.Features.Gymnasts.Queries.GetAllGymnast;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GymnastController : ControllerBase
    {
        private readonly IMediator mediator;
        public GymnastController(IMediator mediator)
        {
            this.mediator = mediator;

        }

        [HttpGet]
        public async Task<IActionResult> GetAllGymnast()
        {
            var response = await mediator.Send(new GetAllGymnastQueryRequest());

            return Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> CreateAllGymnast(CreateGymnastCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> UpdtaeAllGymnast(UpdateGymnastCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAllGymnast(DeleteGymnastCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }
    }
}
