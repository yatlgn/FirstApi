using Api.Application.Bases;
using Api.Application.Features.Coachs.Command.CreateCoach;
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

namespace Api.Application.Features.Competitions.Command.CreateCompetition
{
    public class CreateCompetitionCommandHandler :BaseHandler, IRequestHandler<CreateCompetitionCommandRequest,Unit>
    {
       
        public CreateCompetitionCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            
        }
        public async Task<Unit> Handle(CreateCompetitionCommandRequest request, CancellationToken cancellationToken)
        {
            Competition competition = new(request.CompetitionId, request.CompetitionName, request.CompetitionHall, request.CompetitionType, request.CompetitionDate);

             await unitOfWork.GetWriteRepository<Competition>().AddAsync(competition);
            var result = await unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
