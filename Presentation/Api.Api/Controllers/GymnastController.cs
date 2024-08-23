using Api.Application.Features.Coachs.Queries;
using Api.Application.Features.Gymnasts.Queries.GetAllGymnast;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Api.Controllers
{
    [Route("api/[controller]")]
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
    }
}
