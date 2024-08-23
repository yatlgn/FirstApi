using Api.Application.Features.Coachs.Queries;
using Api.Application.Features.GymnastParents.Queries.GetAllGymnastParent;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GymnastParentController : ControllerBase
    {
        private readonly IMediator mediator;
        public GymnastParentController(IMediator mediator)
        {
            this.mediator = mediator;

        }

        [HttpGet]
        public async Task<IActionResult> GetAllGymnastParent()
        {
            var response = await mediator.Send(new GetAllGymnastParentQueryRequest());

            return Ok(response);
        }
    }
}
