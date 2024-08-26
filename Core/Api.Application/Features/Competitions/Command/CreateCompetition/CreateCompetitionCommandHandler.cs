using Api.Application.Features.Coachs.Command.CreateCoach;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Competitions.Command.CreateCompetition
{
    public class CreateCompetitionCommandHandler : IRequestHandler<CreateCompetitionCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        public CreateCompetitionCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task Handle(CreateCompetitionCommandRequest request, CancellationToken cancellationToken)
        {
            Competition competition = new(request.CompetitionId, request.CompetitionName, request.CompetitionHall, request.CompetitionType, request.CompetitionDate);

             await unitOfWork.GetWriteRepository<Competition>().AddAsync(competition);
            var result = await unitOfWork.SaveAsync();
        }
    }
}
