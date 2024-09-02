using Api.Application.Features.Coachs.Queries;
using Api.Application.Features.Competitions.Command.DeleteCompetition;
using Api.Application.Features.Competitions.Command.UpdateCompetition;
using Api.Application.Features.Workouts.Command.CreateWorkout;
using Api.Application.Features.Workouts.Command.DeleteWorkout;
using Api.Application.Features.Workouts.Command.UpdateWorkout;
using Api.Application.Features.Workouts.Queries.GetAllWorkout;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Api.Controllers
{
    [Route("api/[controller]/[action]")]
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

        [HttpPost]
        public async Task<IActionResult> CreateWorkout(CreateWorkoutCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateWorkout(UpdateWorkoutCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAllWorkout(DeleteWorkoutCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }
    }
}
