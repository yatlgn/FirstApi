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

namespace Api.Application.Features.CompetitionGymnasts.Command.UpdateCompetitionGymnast
{
    public class UpdateCompetitionGymnastCommandHandler : BaseHandler, IRequestHandler<UpdateCompetitionGymnastCommandRequest, Unit>
    {
       
        public UpdateCompetitionGymnastCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            

        }
        public async Task<Unit> Handle(UpdateCompetitionGymnastCommandRequest request, CancellationToken cancellationToken)
        {
            var competition = await unitOfWork.GetReadRepository<CompetitionGymnast>().GetAsync(x => x.Id == request.CompetitionId && !x.IsDeleted);
            var gymnast = await unitOfWork.GetReadRepository<CompetitionGymnast>().GetAsync(x => x.Id == request.GymnastId && !x.IsDeleted);
            var map = mapper.Map<CompetitionGymnast, UpdateCompetitionGymnastCommandRequest>(request);

            return Unit.Value;
        }
    }
}
