using Api.Application.Bases;
using Api.Application.Features.Coachs.Command.DeleteCoach;
using Api.Application.Features.Competitions.Command.CreateCompetition;
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

namespace Api.Application.Features.Competitions.Command.DeleteCompetition
{
    public class DeleteCompetitiontonCommandHandler: BaseHandler, IRequestHandler<DeleteCompetitionCommandRequest, Unit>
    {
        public DeleteCompetitiontonCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            
        }
        public async Task<Unit> Handle(DeleteCompetitionCommandRequest request, CancellationToken cancellationToken)
        {
            var competition = await unitOfWork.GetReadRepository<Competition>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            competition.IsDeleted = false;

            await unitOfWork.GetWriteRepository<Competition>().UpdateAsync(competition);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
