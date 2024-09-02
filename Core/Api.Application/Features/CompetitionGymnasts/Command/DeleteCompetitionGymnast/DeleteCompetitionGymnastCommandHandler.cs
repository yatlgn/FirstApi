using Api.Application.Bases;
using Api.Application.Features.Coachs.Command.DeleteCoach;
using Api.Application.Interfaces;
using Api.Application.Interfaces.AutoMapper;
using Api.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CompetitionGymnasts.Command.DeleteCompetitionGymnast
{
    public class DeleteCompetitionGymnastCommandHandler :BaseHandler, IRequestHandler<DeleteCompetitionGymnastCommandRequest, Unit>
    {
        
        public DeleteCompetitionGymnastCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {


        }
        public async Task<Unit> Handle(DeleteCompetitionGymnastCommandRequest request, CancellationToken cancellationToken)
        {
            var competitiongymnast = await unitOfWork.GetReadRepository<CompetitionGymnast>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            competitiongymnast.IsDeleted = false;

            await unitOfWork.GetWriteRepository<CompetitionGymnast>().UpdateAsync(competitiongymnast);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
