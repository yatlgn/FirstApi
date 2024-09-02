using Api.Application.Features.Coachs.Queries;
using Api.Application.Features.Competitions.Command.CreateCompetition;
using Api.Application.Features.Competitions.Command.DeleteCompetition;
using Api.Application.Features.Competitions.Command.UpdateCompetition;
using Api.Application.Features.Seriess.Command.CreateSeries;
using Api.Application.Features.Seriess.Command.DeleteSeries;
using Api.Application.Features.Seriess.Command.UpdateSeries;
using Api.Application.Features.Seriess.Queries.GetAllSeries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Api.Controllers
{
    [Route("api/[controller]/[action]")]
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


        [HttpPost]
        public async Task<IActionResult> CreateAllSeries(CreateSeriesCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> UpdtaeAllSeries(UpdateSeriesCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }


        [HttpPost]
        public async Task<IActionResult> DeleteAllSeries(DeleteSeriesCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }
    }
}
