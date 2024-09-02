using Api.Application.Bases;
using Api.Application.Interfaces;
using Api.Application.Interfaces.AutoMapper;
using Api.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Coachs.Command.UpdateCoach
{
    public class UpdateCoachCommandHandler :BaseHandler, IRequestHandler<UpdateCoachCommandRequest, Unit>
    {
       
        public UpdateCoachCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
           
            
        }
        public async Task<Unit> Handle(UpdateCoachCommandRequest request, CancellationToken cancellationToken)
        {
            var coach = await unitOfWork.GetReadRepository<Coach>().GetAsync(x => x.Id == request.CoachId && !x.IsDeleted);
            var map = mapper.Map<Coach, UpdateCoachCommandRequest>(request);

            return Unit.Value;
        }
    }
}
