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

namespace Api.Application.Features.CompetitionGymnasts.Command.CreateCompetitionGymnast
{
    public class CreateCompetitionGymnastCommandHandler : BaseHandler, IRequestHandler<CreateCompetitionGymnastCommandRequest, Unit>
    {
        
        public CreateCompetitionGymnastCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
           
        }
        public async Task<Unit> Handle(CreateCompetitionGymnastCommandRequest request, CancellationToken cancellationToken)
        {
            CompetitionGymnast competitiongymnast = new(request.Id, request.GymnastId, request.CompetitionId);

            await unitOfWork.GetWriteRepository<CompetitionGymnast>().AddAsync(competitiongymnast);
            var result = await unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
