using Api.Application.Features.Coachs.Queries;
using Api.Application.Features.Workouts.Queries.GetAllWorkout;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutController : ControllerBase
    {
        private readonly IMediator mediator;
        public WorkoutController(IMediator mediator)
        {
            this.mediator = mediator;

        }

        [HttpGet]
        public async Task<IActionResult> GetAllWorkout()
        {
            var response = await mediator.Send(new GetAllWorkoutQueryRequest());

            return Ok(response);
        }
    }
}
