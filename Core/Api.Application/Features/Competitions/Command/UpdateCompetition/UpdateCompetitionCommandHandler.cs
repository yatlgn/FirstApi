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

namespace Api.Application.Features.Competitions.Command.UpdateCompetition
{
    public class UpdateCompetitionCommandHandler :BaseHandler, IRequestHandler<UpdateCompetitionCommandRequest,Unit>
    {
      
        public UpdateCompetitionCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
           

        }
        public async Task<Unit> Handle(UpdateCompetitionCommandRequest request, CancellationToken cancellationToken)
        {
            var competition = await unitOfWork.GetReadRepository<Competition>().GetAsync(x => x.Id == request.CompetitionId && !x.IsDeleted);
            var map = mapper.Map<Competition, UpdateCompetitionCommandRequest>(request);

            return Unit.Value;
        }
    }
}
