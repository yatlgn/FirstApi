using Api.Application.Features.Coachs.Command.UpdateCoach;
using Api.Application.Interfaces.AutoMapper;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Application.Bases;
using Microsoft.AspNetCore.Http;

namespace Api.Application.Features.CoachGymnasts.Command.UpdateCoachGymnast
{
    public class UpdateCoachGymnastCommandHandler : BaseHandler, IRequestHandler<UpdateCoachGymnastCommandRequest,Unit>
    {
        public UpdateCoachGymnastCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
          

        }
        public async Task<Unit> Handle(UpdateCoachGymnastCommandRequest request, CancellationToken cancellationToken)
        {
            var coach = await unitOfWork.GetReadRepository<CoachGymnast>().GetAsync(x => x.Id == request.CoachId && !x.IsDeleted);
            var gymnast = await unitOfWork.GetReadRepository<CoachGymnast>().GetAsync(x => x.Id == request.GymnastId && !x.IsDeleted);

            var map = mapper.Map<CoachGymnast, UpdateCoachCommandRequest>(request);

            return Unit.Value;
        }
    }
}
