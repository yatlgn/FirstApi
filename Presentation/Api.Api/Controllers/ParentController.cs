using Api.Application.Features.Coachs.Queries;
using Api.Application.Features.Parents.Queries.GetAllParent;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentController : ControllerBase
    {
        private readonly IMediator mediator;
        public ParentController(IMediator mediator)
        {
            this.mediator = mediator;

        }

        [HttpGet]
        public async Task<IActionResult> GetAllParent()
        {
            var response = await mediator.Send(new GetAllParentQueryRequest());

            return Ok(response);
        }
    }
}
