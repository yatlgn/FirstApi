using Api.Application.Features.Coachs.Queries;
using Api.Application.Features.Seriess.Queries.GetAllSeries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        private readonly IMediator mediator;
        public SeriesController(IMediator mediator)
        {
            this.mediator = mediator;

        }

        [HttpGet]
        public async Task<IActionResult> GetAllSeries()
        {
            var response = await mediator.Send(new GetAllSeriesQueryRequest());

            return Ok(response);
        }
    }
}
